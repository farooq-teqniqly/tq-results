# Performance Review Results

**Date**: 2026-01-18 22:44:54 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 05f1d9e5e474fccf21c1ba6ea7bce0668771f93f

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.548 ns | -2.1% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.486 ns | -0.3% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.897 ns | -0.4% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.733 ns | +2.4% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.351 ns | +1.5% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.103 ns | -0.1% | ➡️  |
| GetValue_Success | 9.663 ns | 9.333 ns | -3.4% | ➡️  |
| GetError_Failure | 8.830 ns | 9.057 ns | +2.6% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.863 ns | -0.6% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.911 ns | -0.5% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.664 ns | +5.5% | ⚠️ MINOR |
| CompleteFailureWorkflow | 9.057 ns | 8.776 ns | -3.1% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.1/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 24.0/0.2 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.9/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.8/1.3 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.4/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.5/10.0 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.664 ns (24 B allocated)
- **Change**: +5.5%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
