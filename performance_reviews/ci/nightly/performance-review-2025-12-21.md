# Performance Review Results

**Date**: 2025-12-21 22:44:47 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 2a1ebea7b71f54122d157ec36bfa4c250be126b4

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 2
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.347 ns | -4.7% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.455 ns | -0.7% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.986 ns | +0.7% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.320 ns | -1.9% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.050 ns | -1.8% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.323 ns | +2.3% | ➡️  |
| GetValue_Success | 9.663 ns | 9.334 ns | -3.4% | ➡️  |
| GetError_Failure | 8.830 ns | 8.591 ns | -2.7% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 9.791 ns | +9.8% | ⚠️ MINOR |
| CheckIsFailure_OnFailureResult | 6.949 ns | 7.068 ns | +1.7% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.637 ns | +5.0% | ⚠️ MINOR |
| CompleteFailureWorkflow | 9.057 ns | 8.826 ns | -2.6% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.1/3.0 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 23.1/0.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 9.2/0.0 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 25.6/0.1 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 24.4/0.1 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/2.6 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.8/7.7 | ➡️  |

## Regressions

### CheckIsSuccess_OnSuccessResult - MINOR

- **Baseline**: 8.915 ns (24 B allocated)
- **Current**: 9.791 ns (24 B allocated)
- **Change**: +9.8%
- **Recommendation**: Monitor

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.637 ns (24 B allocated)
- **Change**: +5.0%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **2 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
