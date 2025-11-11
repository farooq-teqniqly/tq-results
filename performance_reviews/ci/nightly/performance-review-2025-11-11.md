# Performance Review Results

**Date**: 2025-11-11 23:40:54 UTC
**Baseline**: 2025-11-11T17:15:55.936790
**Commit**: beccf1db68b763ced73cb37a6198f175c70eea81

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 2
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.580 ns | 7.561 ns | -0.3% | ➡️  |
| CreateSuccessResult_Int | 7.528 ns | 7.338 ns | -2.5% | ➡️  |
| CreateSuccessResult_Unit | 8.090 ns | 7.918 ns | -2.1% | ➡️  |
| CreateFailureResult_String | 9.492 ns | 9.482 ns | -0.1% | ➡️  |
| CreateFailureResult_Int | 9.171 ns | 9.068 ns | -1.1% | ➡️  |
| CreateFailureResult_Unit | 9.147 ns | 9.095 ns | -0.6% | ➡️  |
| GetValue_Success | 9.402 ns | 9.347 ns | -0.6% | ➡️  |
| GetError_Failure | 9.111 ns | 8.823 ns | -3.2% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.943 ns | 9.810 ns | +9.7% | ⚠️ MINOR |
| CheckIsFailure_OnFailureResult | 7.128 ns | 6.937 ns | -2.7% | ➡️  |
| CompleteSuccessWorkflow | 7.240 ns | 7.622 ns | +5.3% | ⚠️ MINOR |
| CompleteFailureWorkflow | 8.808 ns | 8.768 ns | -0.5% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.3/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.9/2.0 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 9.1/0.0 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.5/1.7 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 2.1/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 23.0/1.4 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.7/7.5 | ➡️  |

## Regressions

### CheckIsSuccess_OnSuccessResult - MINOR

- **Baseline**: 8.943 ns (24 B allocated)
- **Current**: 9.810 ns (24 B allocated)
- **Change**: +9.7%
- **Recommendation**: Monitor

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 7.240 ns (24 B allocated)
- **Current**: 7.622 ns (24 B allocated)
- **Change**: +5.3%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **2 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
