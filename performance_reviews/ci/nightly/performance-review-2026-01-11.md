# Performance Review Results

**Date**: 2026-01-11 22:45:11 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: dc3ad0ed1fe79eaee229c8617294c119174ff316

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.792 ns | +1.1% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.584 ns | +1.0% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 8.003 ns | +0.9% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.571 ns | +0.7% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.182 ns | -0.4% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.180 ns | +0.7% | ➡️  |
| GetValue_Success | 9.663 ns | 9.458 ns | -2.1% | ➡️  |
| GetError_Failure | 8.830 ns | 8.912 ns | +0.9% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.962 ns | +0.5% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 7.020 ns | +1.0% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 7.384 ns | +16.9% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 9.102 ns | +0.5% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.1/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 24.3/0.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.9/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/3.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 24.4/0.1 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/3.0 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/7.8 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 7.384 ns (24 B allocated)
- **Change**: +16.9%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
