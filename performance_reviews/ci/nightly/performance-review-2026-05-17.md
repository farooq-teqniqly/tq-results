# Performance Review Results

**Date**: 2026-05-17 22:54:55 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 600977d66e7684e0edc23a1e721a90aff155bf1d

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.502 ns | -2.7% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.456 ns | -0.7% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.861 ns | -0.8% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.413 ns | -1.0% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.047 ns | -1.8% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.027 ns | -0.9% | ➡️  |
| GetValue_Success | 9.663 ns | 9.301 ns | -3.7% | ➡️  |
| GetError_Failure | 8.830 ns | 8.754 ns | -0.9% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.830 ns | -1.0% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.917 ns | -0.5% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.996 ns | +10.7% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.723 ns | -3.7% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.0/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.5/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.9/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.2/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.0/3.0 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/10.0 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.996 ns (24 B allocated)
- **Change**: +10.7%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
