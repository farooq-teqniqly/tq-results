# Performance Review Results

**Date**: 2026-01-25 22:45:37 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 9038a89e18d6089d68b97358668e2e12f484cd59

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 2
- **Improvements**: 1
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.869 ns | +2.1% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.499 ns | -0.2% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.664 ns | -3.3% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.508 ns | +0.0% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.099 ns | -1.3% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.089 ns | -0.3% | ➡️  |
| GetValue_Success | 9.663 ns | 9.030 ns | -6.6% | ✅  |
| GetError_Failure | 8.830 ns | 8.813 ns | -0.2% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.914 ns | -0.0% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 7.310 ns | +5.2% | ⚠️ MINOR |
| CompleteSuccessWorkflow | 6.318 ns | 6.845 ns | +8.3% | ⚠️ MINOR |
| CompleteFailureWorkflow | 9.057 ns | 9.048 ns | -0.1% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.0/2.7 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.7/2.0 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.4/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 2.1/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.5/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/7.7 | ➡️  |

## Regressions

### CheckIsFailure_OnFailureResult - MINOR

- **Baseline**: 6.949 ns (24 B allocated)
- **Current**: 7.310 ns (24 B allocated)
- **Change**: +5.2%
- **Recommendation**: Monitor

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.845 ns (24 B allocated)
- **Change**: +8.3%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **2 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
