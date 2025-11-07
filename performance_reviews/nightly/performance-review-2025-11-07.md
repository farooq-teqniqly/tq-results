# Performance Review Results

**Date**: 2025-11-07 00:18:40 UTC
**Baseline**: 2025-11-06T23:58:41.367009
**Commit**: 

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 4
- **Improvements**: 3
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 8.400 ns | 8.596 ns | +2.3% | ➡️  |
| CreateSuccessResult_Int | 19.009 ns | 8.856 ns | -53.4% | ✅  |
| CreateSuccessResult_Unit | 15.868 ns | 12.286 ns | -22.6% | ✅  |
| CreateFailureResult_String | 9.046 ns | 9.644 ns | +6.6% | ⚠️ MINOR |
| CreateFailureResult_Int | 8.987 ns | 9.516 ns | +5.9% | ⚠️ MINOR |
| CreateFailureResult_Unit | 8.917 ns | 9.616 ns | +7.8% | ⚠️ MINOR |
| GetValue_Success | 9.637 ns | 9.928 ns | +3.0% | ➡️  |
| GetError_Failure | 8.162 ns | 8.934 ns | +9.5% | ⚠️ MINOR |
| CheckIsSuccess_OnSuccessResult | 8.612 ns | 8.809 ns | +2.3% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.685 ns | 6.941 ns | +3.8% | ➡️  |
| CompleteSuccessWorkflow | 13.593 ns | 8.219 ns | -39.5% | ✅  |
| CompleteFailureWorkflow | 8.780 ns | 8.496 ns | -3.2% | ➡️  |
| NestedResults | 13.950 ns | 14.320 ns | +2.7% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1/2 | Status |
|-----------|----------|---------|--------------|----------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 0.0/5.0/1.2 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 0.0/3.8/0.7 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 0.0/1.4/0.1 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 0.0/5.2/1.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 0.0/3.8/0.7 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.0/0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 0.0/0.6/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 0.0/5.1/1.0 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 0.0/11.7/5.7 | ➡️  |

## Regressions

### CreateFailureResult_String - MINOR

- **Baseline**: 9.046 ns (24 B allocated)
- **Current**: 9.644 ns (24 B allocated)
- **Change**: +6.6%
- **Recommendation**: Monitor

### CreateFailureResult_Int - MINOR

- **Baseline**: 8.987 ns (24 B allocated)
- **Current**: 9.516 ns (24 B allocated)
- **Change**: +5.9%
- **Recommendation**: Monitor

### CreateFailureResult_Unit - MINOR

- **Baseline**: 8.917 ns (24 B allocated)
- **Current**: 9.616 ns (24 B allocated)
- **Change**: +7.8%
- **Recommendation**: Monitor

### GetError_Failure - MINOR

- **Baseline**: 8.162 ns (24 B allocated)
- **Current**: 8.934 ns (24 B allocated)
- **Change**: +9.5%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **4 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
