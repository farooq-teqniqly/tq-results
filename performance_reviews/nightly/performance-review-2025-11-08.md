# Performance Review Results

**Date**: 2025-11-08 01:04:19 UTC
**Baseline**: 2025-11-07T01:16:16.472257
**Commit**: 

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 2
- **Improvements**: 2
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.354 ns | 7.136 ns | -3.0% | ➡️  |
| CreateSuccessResult_Int | 7.237 ns | 7.899 ns | +9.1% | ⚠️ MINOR |
| CreateSuccessResult_Unit | 17.208 ns | 11.627 ns | -32.4% | ✅  |
| CreateFailureResult_String | 8.954 ns | 9.011 ns | +0.6% | ➡️  |
| CreateFailureResult_Int | 8.824 ns | 8.737 ns | -1.0% | ➡️  |
| CreateFailureResult_Unit | 9.120 ns | 8.611 ns | -5.6% | ✅  |
| GetValue_Success | 9.014 ns | 8.849 ns | -1.8% | ➡️  |
| GetError_Failure | 7.971 ns | 8.215 ns | +3.1% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.483 ns | 8.668 ns | +2.2% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.605 ns | 6.557 ns | -0.7% | ➡️  |
| CompleteSuccessWorkflow | 13.194 ns | 14.396 ns | +9.1% | ⚠️ MINOR |
| CompleteFailureWorkflow | 8.140 ns | 7.917 ns | -2.7% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 5.0/1.1 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 3.7/0.6 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 1.4/0.1 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 5.2/1.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 3.8/0.7 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.0/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 0.6/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 5.0/1.0 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 11.6/5.7 | ➡️  |

## Regressions

### CreateSuccessResult_Int - MINOR

- **Baseline**: 7.237 ns (24 B allocated)
- **Current**: 7.899 ns (24 B allocated)
- **Change**: +9.1%
- **Recommendation**: Monitor

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 13.194 ns (24 B allocated)
- **Current**: 14.396 ns (24 B allocated)
- **Change**: +9.1%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **2 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
