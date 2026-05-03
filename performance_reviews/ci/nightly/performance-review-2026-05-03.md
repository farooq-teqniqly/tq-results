# Performance Review Results

**Date**: 2026-05-03 22:53:12 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: cf9ff4958ac2303d3a423f0be2d7f0ae23a0a031

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.759 ns | +0.6% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.517 ns | +0.1% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 8.169 ns | +3.0% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.486 ns | -0.2% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.112 ns | -1.1% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.101 ns | -0.1% | ➡️  |
| GetValue_Success | 9.663 ns | 9.367 ns | -3.1% | ➡️  |
| GetError_Failure | 8.830 ns | 8.933 ns | +1.2% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.858 ns | -0.6% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.949 ns | 0.0% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.764 ns | +7.1% | ⚠️ MINOR |
| CompleteFailureWorkflow | 9.057 ns | 8.782 ns | -3.0% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.1/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.5/2.0 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.8 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.5/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.0/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/9.9 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.764 ns (24 B allocated)
- **Change**: +7.1%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
