# Performance Review Results

**Date**: 2026-02-08 22:50:41 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 33469983f208963b3c5751e44c014cf441e2aba4

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.530 ns | -2.3% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.379 ns | -1.8% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.960 ns | +0.4% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.539 ns | +0.4% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.135 ns | -0.9% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.178 ns | +0.7% | ➡️  |
| GetValue_Success | 9.663 ns | 9.351 ns | -3.2% | ➡️  |
| GetError_Failure | 8.830 ns | 8.822 ns | -0.1% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.931 ns | +0.2% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.981 ns | +0.5% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.748 ns | +6.8% | ⚠️ MINOR |
| CompleteFailureWorkflow | 9.057 ns | 8.825 ns | -2.6% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.2/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.8/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.7/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.4/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/9.9 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.748 ns (24 B allocated)
- **Change**: +6.8%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
