# Performance Review Results

**Date**: 2025-11-09 02:43:35 UTC
**Baseline**: 2025-11-08T21:44:25.559241
**Commit**: 3e0f4115135b917f6d3ebbed2e74e8e3641d589a

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.480 ns | 7.344 ns | -1.8% | ➡️  |
| CreateSuccessResult_Int | 7.442 ns | 7.279 ns | -2.2% | ➡️  |
| CreateSuccessResult_Unit | 7.847 ns | 7.871 ns | +0.3% | ➡️  |
| CreateFailureResult_String | 9.418 ns | 9.437 ns | +0.2% | ➡️  |
| CreateFailureResult_Int | 9.047 ns | 9.032 ns | -0.2% | ➡️  |
| CreateFailureResult_Unit | 9.045 ns | 9.056 ns | +0.1% | ➡️  |
| GetValue_Success | 8.979 ns | 9.598 ns | +6.9% | ⚠️ MINOR |
| GetError_Failure | 8.772 ns | 8.792 ns | +0.2% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.816 ns | 8.836 ns | +0.2% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.901 ns | 7.088 ns | +2.7% | ➡️  |
| CompleteSuccessWorkflow | 7.006 ns | 6.983 ns | -0.3% | ➡️  |
| CompleteFailureWorkflow | 8.477 ns | 8.751 ns | +3.2% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.1/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.6/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 4.0/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.2/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.4/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.8/7.7 | ➡️  |

## Regressions

### GetValue_Success - MINOR

- **Baseline**: 8.979 ns (24 B allocated)
- **Current**: 9.598 ns (24 B allocated)
- **Change**: +6.9%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
