# Performance Review Results

**Date**: 2026-06-07 22:57:42 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: c01630ca55a1bb5a14183ad1d787b3d711f31ec6

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 1
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.590 ns | -1.5% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.565 ns | +0.7% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.978 ns | +0.6% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.516 ns | +0.1% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.364 ns | +1.6% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.121 ns | +0.1% | ➡️  |
| GetValue_Success | 9.663 ns | 9.107 ns | -5.8% | ✅  |
| GetError_Failure | 8.830 ns | 8.853 ns | +0.3% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.939 ns | +0.3% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.996 ns | +0.7% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 7.164 ns | +13.4% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.863 ns | -2.1% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.3/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 22.0/0.2 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 9.5/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/7.6 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 7.164 ns (24 B allocated)
- **Change**: +13.4%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
