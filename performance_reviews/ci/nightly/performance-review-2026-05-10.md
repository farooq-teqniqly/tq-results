# Performance Review Results

**Date**: 2026-05-10 22:53:50 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 7b7abe4a4a71c12c417ff9e3af5b6d664acadfa5

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 1
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.527 ns | -2.4% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.505 ns | -0.1% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.920 ns | -0.1% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.485 ns | -0.2% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.081 ns | -1.5% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.096 ns | -0.2% | ➡️  |
| GetValue_Success | 9.663 ns | 9.019 ns | -6.7% | ✅  |
| GetError_Failure | 8.830 ns | 8.825 ns | -0.1% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.863 ns | -0.6% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.923 ns | -0.4% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 7.025 ns | +11.2% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.762 ns | -3.3% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.2/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.7/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.1/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.4/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.8/7.5 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 7.025 ns (24 B allocated)
- **Change**: +11.2%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
