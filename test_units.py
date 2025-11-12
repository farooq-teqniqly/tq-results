#!/usr/bin/env python3
"""Test unit conversion functionality."""

import re

def _clean_numeric_value(value_str: str, default: float = 0.0, is_int: bool = False) -> float | int:
    """Clean and convert numeric CSV values with proper unit normalization.

    Handles time units (s, ms, us/µs, ns) -> nanoseconds
    Handles size units (B, KB, MB, GB) -> bytes
    """
    if not value_str or value_str.strip() == "-" or value_str.strip() == "":
        return default

    # Trim whitespace and remove quotes
    cleaned = value_str.strip().replace('"', "")

    # Use regex to extract numeric value and unit
    match = re.match(r'^([0-9,]+(?:\.[0-9]+)?)\s*(.*)$', cleaned)
    if not match:
        return default

    num_str, unit = match.groups()
    num_str = num_str.replace(",", "")  # Remove commas

    try:
        value = float(num_str)
    except ValueError:
        return default

    # Normalize units
    unit = unit.strip().lower()

    # Time unit conversions to nanoseconds
    if unit in ("s", "sec"):
        value *= 1_000_000_000  # seconds to nanoseconds
    elif unit in ("ms", "msec"):
        value *= 1_000_000  # milliseconds to nanoseconds
    elif unit in ("us", "µs", "μs"):
        value *= 1_000  # microseconds to nanoseconds
    elif unit == "ns":
        pass  # already in nanoseconds
    # Size unit conversions to bytes
    elif unit == "kb":
        value *= 1_024  # kilobytes to bytes
    elif unit == "mb":
        value *= 1_024 * 1_024  # megabytes to bytes
    elif unit == "gb":
        value *= 1_024 * 1_024 * 1_024  # gigabytes to bytes
    elif unit in ("b", ""):
        pass  # already in bytes or no unit
    else:
        # Unknown unit, return default
        return default

    return int(value) if is_int else value

# Test cases
test_cases = [
    ("4.186 ns", 4.186),  # nanoseconds (no conversion)
    ("1.5 ms", 1_500_000),  # milliseconds to nanoseconds
    ("2.5 us", 2_500),  # microseconds to nanoseconds
    ("2.5 µs", 2_500),  # micro symbol to nanoseconds
    ("2.5 μs", 2_500),  # mu symbol to nanoseconds
    ("1 s", 1_000_000_000),  # seconds to nanoseconds
    ("24 B", 24),  # bytes (no conversion)
    ("1 KB", 1024),  # kilobytes to bytes
    ("1 MB", 1024 * 1024),  # megabytes to bytes
    ("1 GB", 1024 * 1024 * 1024),  # gigabytes to bytes
    ("42", 42),  # no unit (assume bytes for int, ns for float)
    ("-", 0),  # dash should return default
    ("", 0),  # empty should return default
    ("invalid", 0),  # invalid should return default
]

print("Testing unit conversions:")
for input_val, expected in test_cases:
    result = _clean_numeric_value(input_val, is_int=(expected > 100))  # Use int for large values
    status = "✅" if result == expected else "❌"
    print(f"{status} '{input_val}' -> {result} (expected {expected})")

print("\nAll tests completed!")
