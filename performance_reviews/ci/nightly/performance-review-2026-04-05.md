# Performance Review Results

**Date**: 2026-04-05 22:51:29 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 7ab9b8a33f324c5a9c2368f5f4d7ebbf6553a5b8

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.566 ns | -1.9% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.496 ns | -0.2% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.946 ns | +0.2% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.499 ns | -0.1% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.101 ns | -1.2% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.092 ns | -0.2% | ➡️  |
| GetValue_Success | 9.663 ns | 9.346 ns | -3.3% | ➡️  |
| GetError_Failure | 8.830 ns | 8.838 ns | +0.1% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.861 ns | -0.6% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.895 ns | -0.8% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.859 ns | +8.6% | ⚠️ MINOR |
| CompleteFailureWorkflow | 9.057 ns | 8.742 ns | -3.5% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.3/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.6/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.2/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/3.0 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.8/7.5 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.859 ns (24 B allocated)
- **Change**: +8.6%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
