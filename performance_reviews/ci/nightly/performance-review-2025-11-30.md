# Performance Review Results

**Date**: 2025-11-30 22:43:56 UTC
**Baseline**: 2025-11-23T22:43:54.051505
**Commit**: 105690d6c5ca8783d599c4fd64de330274202444

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.565 ns | 7.572 ns | +0.1% | ➡️  |
| CreateSuccessResult_Int | 7.506 ns | 7.705 ns | +2.7% | ➡️  |
| CreateSuccessResult_Unit | 7.932 ns | 7.903 ns | -0.4% | ➡️  |
| CreateFailureResult_String | 9.490 ns | 9.468 ns | -0.2% | ➡️  |
| CreateFailureResult_Int | 9.136 ns | 9.116 ns | -0.2% | ➡️  |
| CreateFailureResult_Unit | 9.073 ns | 9.099 ns | +0.3% | ➡️  |
| GetValue_Success | 9.350 ns | 9.366 ns | +0.2% | ➡️  |
| GetError_Failure | 8.861 ns | 8.843 ns | -0.2% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 9.043 ns | 8.827 ns | -2.4% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.936 ns | 7.908 ns | +14.0% | ⚠️ MAJOR |
| CompleteSuccessWorkflow | 7.190 ns | 7.102 ns | -1.2% | ➡️  |
| CompleteFailureWorkflow | 9.004 ns | 9.020 ns | +0.2% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.5/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.5/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.8/3.4 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 24.4/0.1 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.6/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.7/8.0 | ➡️  |

## Regressions

### CheckIsFailure_OnFailureResult - MAJOR

- **Baseline**: 6.936 ns (24 B allocated)
- **Current**: 7.908 ns (24 B allocated)
- **Change**: +14.0%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
