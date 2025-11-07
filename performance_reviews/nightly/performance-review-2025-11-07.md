# Performance Review Results

**Date**: 2025-11-07 00:36:59 UTC
**Baseline**: 2025-11-06T23:58:41.367009
**Commit**: 

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 7
- **Improvements**: 2
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 8.400 ns | 7.842 ns | -6.6% | ✅  |
| CreateSuccessResult_Int | 19.009 ns | 7.757 ns | -59.2% | ✅  |
| CreateSuccessResult_Unit | 15.868 ns | 17.424 ns | +9.8% | ⚠️ MINOR |
| CreateFailureResult_String | 9.046 ns | 9.679 ns | +7.0% | ⚠️ MINOR |
| CreateFailureResult_Int | 8.987 ns | 9.465 ns | +5.3% | ⚠️ MINOR |
| CreateFailureResult_Unit | 8.917 ns | 9.392 ns | +5.3% | ⚠️ MINOR |
| GetValue_Success | 9.637 ns | 9.619 ns | -0.2% | ➡️  |
| GetError_Failure | 8.162 ns | 8.644 ns | +5.9% | ⚠️ MINOR |
| CheckIsSuccess_OnSuccessResult | 8.612 ns | 9.007 ns | +4.6% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.685 ns | 7.081 ns | +5.9% | ⚠️ MINOR |
| CompleteSuccessWorkflow | 13.593 ns | 14.609 ns | +7.5% | ⚠️ MINOR |
| CompleteFailureWorkflow | 8.780 ns | 8.754 ns | -0.3% | ➡️  |
| NestedResults | 13.950 ns | 14.590 ns | +4.6% | ➡️  |

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

### CreateSuccessResult_Unit - MINOR

- **Baseline**: 15.868 ns (24 B allocated)
- **Current**: 17.424 ns (24 B allocated)
- **Change**: +9.8%
- **Recommendation**: Monitor

### CreateFailureResult_String - MINOR

- **Baseline**: 9.046 ns (24 B allocated)
- **Current**: 9.679 ns (24 B allocated)
- **Change**: +7.0%
- **Recommendation**: Monitor

### CreateFailureResult_Int - MINOR

- **Baseline**: 8.987 ns (24 B allocated)
- **Current**: 9.465 ns (24 B allocated)
- **Change**: +5.3%
- **Recommendation**: Monitor

### CreateFailureResult_Unit - MINOR

- **Baseline**: 8.917 ns (24 B allocated)
- **Current**: 9.392 ns (24 B allocated)
- **Change**: +5.3%
- **Recommendation**: Monitor

### GetError_Failure - MINOR

- **Baseline**: 8.162 ns (24 B allocated)
- **Current**: 8.644 ns (24 B allocated)
- **Change**: +5.9%
- **Recommendation**: Monitor

### CheckIsFailure_OnFailureResult - MINOR

- **Baseline**: 6.685 ns (24 B allocated)
- **Current**: 7.081 ns (24 B allocated)
- **Change**: +5.9%
- **Recommendation**: Monitor

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 13.593 ns (24 B allocated)
- **Current**: 14.609 ns (24 B allocated)
- **Change**: +7.5%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **7 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
