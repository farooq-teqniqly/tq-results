# Performance Review Results

**Date**: 2025-12-28 22:45:02 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 35f7944fdf8cc00d353b2401e07e06234391648d

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.406 ns | -3.9% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.567 ns | +0.7% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.992 ns | +0.8% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.779 ns | +2.9% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.415 ns | +2.2% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.211 ns | +1.1% | ➡️  |
| GetValue_Success | 9.663 ns | 9.410 ns | -2.6% | ➡️  |
| GetError_Failure | 8.830 ns | 9.128 ns | +3.4% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.942 ns | +0.3% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 7.024 ns | +1.1% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 7.088 ns | +12.2% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.868 ns | -2.1% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.1/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.6/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 9.2/0.0 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.8 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.2/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.8/7.7 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 7.088 ns (24 B allocated)
- **Change**: +12.2%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
