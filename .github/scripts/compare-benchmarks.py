#!/usr/bin/env python3
"""
Compare BenchmarkDotNet results against baseline and detect performance regressions.
"""

import argparse
import json
import re
import sys
from datetime import datetime
from pathlib import Path


class BenchmarkResult:
    """Represents a single benchmark result."""

    def __init__(
        self,
        name: str,
        mean_ns: float,
        error_ns: float = 0,
        stddev_ns: float = 0,
        allocated_bytes: int = 0,
        gen0: float = 0,
        gen1: float = 0,
        gen2: float = 0,
    ):
        self.name = name
        self.mean_ns = mean_ns
        self.error_ns = error_ns
        self.stddev_ns = stddev_ns
        self.allocated_bytes = allocated_bytes
        self.gen0 = gen0
        self.gen1 = gen1
        self.gen2 = gen2


class RegressionDetector:
    """Detects performance regressions by comparing results."""

    THRESHOLD_MINOR = 0.05  # 5%
    THRESHOLD_MAJOR = 0.10  # 10%
    THRESHOLD_CRITICAL = 0.20  # 20%

    @staticmethod
    def compare_cpu(
        baseline: BenchmarkResult, current: BenchmarkResult
    ) -> tuple[str, float, str]:
        """Compare CPU benchmark results. Returns (status, change_pct, severity)."""
        if baseline.mean_ns == 0:
            return "➡️", 0.0, "NONE"

        change_pct = ((current.mean_ns - baseline.mean_ns) / baseline.mean_ns) * 100

        if abs(change_pct) < RegressionDetector.THRESHOLD_MINOR * 100:
            return "➡️", change_pct, "NONE"
        elif change_pct < 0:
            return "✅", change_pct, "IMPROVEMENT"
        elif change_pct > RegressionDetector.THRESHOLD_CRITICAL * 100:
            return "⚠️", change_pct, "CRITICAL"
        elif change_pct > RegressionDetector.THRESHOLD_MAJOR * 100:
            return "⚠️", change_pct, "MAJOR"
        else:
            return "⚠️", change_pct, "MINOR"

    @staticmethod
    def compare_memory(
        baseline: BenchmarkResult, current: BenchmarkResult
    ) -> tuple[str, float, str]:
        """Compare memory benchmark results. Returns (status, change_pct, severity)."""
        if baseline.allocated_bytes == 0:
            return "➡️", 0.0, "NONE"

        change_pct = (
            (current.allocated_bytes - baseline.allocated_bytes)
            / baseline.allocated_bytes
        ) * 100

        # Check for Gen2 collections increase (critical)
        if current.gen2 > baseline.gen2:
            return "⚠️", change_pct, "CRITICAL"

        if abs(change_pct) < RegressionDetector.THRESHOLD_MINOR * 100:
            return "➡️", change_pct, "NONE"
        elif change_pct < 0:
            return "✅", change_pct, "IMPROVEMENT"
        elif change_pct > RegressionDetector.THRESHOLD_CRITICAL * 100:
            return "⚠️", change_pct, "CRITICAL"
        elif change_pct > RegressionDetector.THRESHOLD_MAJOR * 100:
            return "⚠️", change_pct, "MAJOR"
        else:
            return "⚠️", change_pct, "MINOR"


def _find_table_start(lines: list[str]) -> int:
    """Find the starting line of the markdown table."""
    for i, line in enumerate(lines):
        if "|" in line and "Method" in line:
            return i
    return -1


def _parse_mean_value(mean_str: str) -> float:
    """Parse mean time value and convert to nanoseconds."""
    cleaned = mean_str.replace(",", "").replace(" ns", "").replace(" us", "")
    mean_ns = float(cleaned)

    # Convert microseconds to nanoseconds if needed
    if "us" in mean_str or "μs" in mean_str:
        mean_ns *= 1000

    return mean_ns


def _parse_allocated_bytes(parts: list[str]) -> int:
    """Parse allocated bytes from table parts."""
    for part in parts:
        if "B" in part and part[0].isdigit():
            return int(part.replace(",", "").replace(" B", ""))
    return 0


def _parse_gen_columns(parts: list[str]) -> tuple[float, float, float]:
    """Parse Gen0/Gen1/Gen2 columns from table parts."""
    gen0 = gen1 = gen2 = 0.0

    if len(parts) <= 4:
        return gen0, gen1, gen2

    try:
        for i, part in enumerate(parts):
            if part.replace(".", "").replace("-", "").isdigit() or part == "-":
                val = 0.0 if part == "-" else float(part)
                if i == len(parts) - 4:  # Gen0
                    gen0 = val
                elif i == len(parts) - 3:  # Gen1
                    gen1 = val
                elif i == len(parts) - 2:  # Gen2 (before Allocated)
                    gen2 = val
    except (ValueError, IndexError):
        pass

    return gen0, gen1, gen2


def _parse_table_row(parts: list[str]) -> BenchmarkResult | None:
    """Parse a single table row into a BenchmarkResult."""
    if len(parts) < 2:
        return None

    try:
        name = parts[0]
        mean_ns = _parse_mean_value(parts[1])
        allocated = _parse_allocated_bytes(parts)
        gen0, gen1, gen2 = _parse_gen_columns(parts)

        return BenchmarkResult(
            name=name,
            mean_ns=mean_ns,
            allocated_bytes=allocated,
            gen0=gen0,
            gen1=gen1,
            gen2=gen2,
        )
    except (ValueError, IndexError):
        return None


def parse_markdown_table(content: str) -> list[BenchmarkResult]:
    """Parse BenchmarkDotNet markdown table into benchmark results."""
    results = []
    lines = content.split("\n")

    table_start = _find_table_start(lines)
    if table_start == -1:
        return results

    # Skip header and separator
    data_start = table_start + 2

    for line in lines[data_start:]:
        if not line.strip() or "|" not in line:
            break

        parts = [p.strip() for p in line.split("|")][1:-1]  # Remove empty first/last
        result = _parse_table_row(parts)

        if result:
            results.append(result)
        else:
            print(f"Warning: Could not parse line: {line.strip()}", file=sys.stderr)

    return results


def load_baseline(path: str) -> dict[str, BenchmarkResult]:
    """Load baseline from JSON file."""
    with open(path, "r") as f:
        data = json.load(f)

    results = {}

    for bench in data.get("cpu_benchmarks", []):
        results[bench["name"]] = BenchmarkResult(
            name=bench["name"],
            mean_ns=bench["mean_ns"],
            error_ns=bench.get("error_ns", 0),
            stddev_ns=bench.get("stddev_ns", 0),
            allocated_bytes=bench.get("allocated_bytes", 0),
        )

    for bench in data.get("memory_benchmarks", []):
        results[bench["name"]] = BenchmarkResult(
            name=bench["name"],
            mean_ns=bench["mean_ns"],
            allocated_bytes=bench.get("allocated_bytes", 0),
            gen0=bench.get("gen0", 0),
            gen1=bench.get("gen1", 0),
            gen2=bench.get("gen2", 0),
        )

    return results


def save_baseline(results: dict[str, BenchmarkResult], path: str, commit: str = ""):
    """Save results as new baseline JSON."""
    cpu_benchmarks = []
    memory_benchmarks = []

    for name, result in results.items():
        bench_data = {
            "name": result.name,
            "mean_ns": result.mean_ns,
            "error_ns": result.error_ns,
            "stddev_ns": result.stddev_ns,
            "allocated_bytes": result.allocated_bytes,
        }

        # Distinguish CPU vs Memory benchmarks by presence of Gen data
        if result.gen0 > 0 or result.gen1 > 0 or "Memory" in name:
            bench_data["gen0"] = result.gen0
            bench_data["gen1"] = result.gen1
            bench_data["gen2"] = result.gen2
            memory_benchmarks.append(bench_data)
        else:
            cpu_benchmarks.append(bench_data)

    baseline = {
        "date": datetime.now().isoformat(),
        "commit": commit,
        "runtime": ".NET 9.0",
        "cpu_benchmarks": cpu_benchmarks,
        "memory_benchmarks": memory_benchmarks,
    }

    Path(path).parent.mkdir(parents=True, exist_ok=True)
    with open(path, "w") as f:
        json.dump(baseline, f, indent=2)


def _is_memory_benchmark(result: BenchmarkResult, name: str) -> bool:
    """Determine if a benchmark is a memory benchmark."""
    return result.gen0 > 0 or "Memory" in name or result.mean_ns > 100


def _compare_benchmark(
    name: str,
    baseline_result: BenchmarkResult,
    current_result: BenchmarkResult,
) -> tuple[str, float, str, bool]:
    """Compare a single benchmark. Returns (status, change_pct, severity, is_memory)."""
    is_memory = _is_memory_benchmark(current_result, name)

    if is_memory:
        status, change_pct, severity = RegressionDetector.compare_memory(
            baseline_result, current_result
        )
    else:
        status, change_pct, severity = RegressionDetector.compare_cpu(
            baseline_result, current_result
        )

    return status, change_pct, severity, is_memory


def _build_summary_section(
    baseline_date: str,
    commit: str,
    total: int,
    regressions_count: int,
    improvements_count: int,
    max_severity: str,
) -> str:
    """Build the summary section of the review."""
    status = (
        "✅ PASS" if regressions_count == 0 else f"⚠️ REGRESSIONS FOUND ({max_severity})"
    )

    return f"""# Performance Review Results

**Date**: {datetime.now().strftime('%Y-%m-%d %H:%M:%S UTC')}
**Baseline**: {baseline_date}
**Commit**: {commit}

## Summary

- **Total Benchmarks**: {total}
- **Regressions**: {regressions_count}
- **Improvements**: {improvements_count}
- **Status**: {status}

"""


def _build_cpu_benchmarks_table(cpu_comparisons: list) -> str:
    """Build the CPU benchmarks comparison table."""
    md = """## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
"""

    for name, baseline_r, current_r, status, change, severity in cpu_comparisons:
        sign = "+" if change > 0 else ""
        severity_text = severity if severity not in ["NONE", "IMPROVEMENT"] else ""
        md += f"| {name} | {baseline_r.mean_ns:.3f} ns | {current_r.mean_ns:.3f} ns | {sign}{change:.1f}% | {status} {severity_text} |\n"

    return md


def _build_memory_benchmarks_table(memory_comparisons: list) -> str:
    """Build the memory benchmarks comparison table."""
    md = """\n## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1/2 | Status |
|-----------|----------|---------|--------------|----------|--------|
"""

    for name, baseline_r, current_r, status, change, severity in memory_comparisons:
        sign = "+" if change > 0 else ""
        gen_info = f"{current_r.gen0:.1f}/{current_r.gen1:.1f}/{current_r.gen2:.1f}"
        severity_text = severity if severity not in ["NONE", "IMPROVEMENT"] else ""
        md += f"| {name} | {baseline_r.allocated_bytes:,} B | {current_r.allocated_bytes:,} B | {sign}{change:.1f}% | {gen_info} | {status} {severity_text} |\n"

    return md


def _get_recommendation(severity: str) -> str:
    """Get recommendation based on regression severity."""
    if severity == "CRITICAL":
        return "Fix before merge"
    elif severity == "MINOR":
        return "Monitor"
    else:
        return "Investigate"


def _build_regressions_section(regressions: list) -> str:
    """Build the regressions detail section."""
    if not regressions:
        return ""

    md = "\n## Regressions\n\n"

    for name, baseline_r, current_r, change, severity in regressions:
        recommendation = _get_recommendation(severity)

        md += f"""### {name} - {severity}

- **Baseline**: {baseline_r.mean_ns:.3f} ns ({baseline_r.allocated_bytes:,} B allocated)
- **Current**: {current_r.mean_ns:.3f} ns ({current_r.allocated_bytes:,} B allocated)
- **Change**: +{change:.1f}%
- **Recommendation**: {recommendation}

"""

    return md


def _build_action_items_section(has_regressions: bool) -> str:
    """Build the action items section."""
    md = "\n## Action Items\n\n"

    if has_regressions:
        md += "- [ ] Review regression details above\n"
        md += "- [ ] Investigate root cause of performance degradation\n"
        md += "- [ ] Fix regression or document justification\n"
    else:
        md += "- [x] No regressions detected\n"
        md += "- [x] Baseline will be automatically updated\n"

    return md


def _build_conclusion_section(regressions_count: int, max_severity: str) -> str:
    """Build the conclusion section."""
    md = "\n## Conclusion\n\n"

    if regressions_count > 0:
        md += f"⚠️ **{regressions_count} regression(s) detected with {max_severity} severity.** "
        md += "Please review and address before baseline is updated.\n"
    else:
        md += "✅ **All benchmarks passed.** Performance is within acceptable range of baseline.\n"

    return md


def generate_review(
    baseline: dict[str, BenchmarkResult],
    current: dict[str, BenchmarkResult],
    baseline_date: str,
    commit: str,
) -> tuple[str, bool, str]:
    """Generate performance review markdown. Returns (content, has_regression, severity)."""

    cpu_comparisons = []
    memory_comparisons = []
    regressions = []
    improvements = []
    max_severity = "NONE"

    severity_rank = {"NONE": 0, "IMPROVEMENT": 0, "MINOR": 1, "MAJOR": 2, "CRITICAL": 3}

    # Compare all benchmarks
    for name, current_result in current.items():
        if name not in baseline:
            continue

        baseline_result = baseline[name]
        status, change_pct, severity, is_memory = _compare_benchmark(
            name, baseline_result, current_result
        )

        comparison = (
            name,
            baseline_result,
            current_result,
            status,
            change_pct,
            severity,
        )

        if is_memory:
            memory_comparisons.append(comparison)
        else:
            cpu_comparisons.append(comparison)

        if severity in ["MINOR", "MAJOR", "CRITICAL"]:
            regressions.append(
                (name, baseline_result, current_result, change_pct, severity)
            )
            if severity_rank[severity] > severity_rank[max_severity]:
                max_severity = severity
        elif severity == "IMPROVEMENT":
            improvements.append((name, baseline_result, current_result, change_pct))

    # Build markdown document
    md = _build_summary_section(
        baseline_date,
        commit,
        len(current),
        len(regressions),
        len(improvements),
        max_severity,
    )
    md += _build_cpu_benchmarks_table(cpu_comparisons)
    md += _build_memory_benchmarks_table(memory_comparisons)
    md += _build_regressions_section(regressions)
    md += _build_action_items_section(len(regressions) > 0)
    md += _build_conclusion_section(len(regressions), max_severity)

    return md, len(regressions) > 0, max_severity


def main():
    parser = argparse.ArgumentParser(
        description="Compare benchmark results against baseline"
    )
    parser.add_argument("--baseline", required=True, help="Path to baseline JSON file")
    parser.add_argument(
        "--cpu-results", required=True, help="Path to CPU benchmark markdown results"
    )
    parser.add_argument(
        "--memory-results",
        required=True,
        help="Path to memory benchmark markdown results",
    )
    parser.add_argument(
        "--output", required=True, help="Output path for performance review"
    )
    parser.add_argument(
        "--new-baseline", required=True, help="Output path for new baseline JSON"
    )
    parser.add_argument("--commit", default="", help="Git commit SHA")

    args = parser.parse_args()

    # Load baseline
    baseline_results = load_baseline(args.baseline)

    # Load baseline metadata
    with open(args.baseline, "r") as f:
        baseline_data = json.load(f)
    baseline_date = baseline_data.get("date", "unknown")

    # Parse current results
    current_results = {}

    with open(args.cpu_results, "r") as f:
        cpu_content = f.read()
        for result in parse_markdown_table(cpu_content):
            current_results[result.name] = result

    with open(args.memory_results, "r") as f:
        memory_content = f.read()
        for result in parse_markdown_table(memory_content):
            current_results[result.name] = result

    # Generate review
    review_md, has_regression, severity = generate_review(
        baseline_results, current_results, baseline_date, args.commit
    )

    # Write review
    Path(args.output).parent.mkdir(parents=True, exist_ok=True)
    with open(args.output, "w") as f:
        f.write(review_md)

    # Save new baseline (always save, workflow decides whether to use it)
    save_baseline(current_results, args.new_baseline, args.commit)

    # Create marker files for workflow
    if has_regression:
        with open(".regression-detected", "w") as f:
            f.write("true")
        with open(".regression-severity", "w") as f:
            f.write(severity)

    print(f"Performance review generated: {args.output}")
    print(f"Status: {'⚠️ REGRESSIONS FOUND' if has_regression else '✅ PASS'}")
    if has_regression:
        print(f"Severity: {severity}")

    return 1 if has_regression else 0


if __name__ == "__main__":
    sys.exit(main())
