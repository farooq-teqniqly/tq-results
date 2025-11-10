# Performance Review Results

**Date**: 2025-11-10 20:53:24 UTC
**Baseline**: 2025-11-08T21:44:25.559241
**Commit**: 1cf75be2fa3006da00c0c0b614836f0c0477b74e

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 2
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.480 ns | 7.865 ns | +5.1% | ⚠️ MINOR |
| CreateSuccessResult_Int | 7.442 ns | 7.573 ns | +1.8% | ➡️  |
| CreateSuccessResult_Unit | 7.847 ns | 7.800 ns | -0.6% | ➡️  |
| CreateFailureResult_String | 9.418 ns | 9.550 ns | +1.4% | ➡️  |
| CreateFailureResult_Int | 9.047 ns | 9.109 ns | +0.7% | ➡️  |
| CreateFailureResult_Unit | 9.045 ns | 9.025 ns | -0.2% | ➡️  |
| GetValue_Success | 8.979 ns | 8.849 ns | -1.4% | ➡️  |
| GetError_Failure | 8.772 ns | 9.138 ns | +4.2% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.816 ns | 8.947 ns | +1.5% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.901 ns | 6.984 ns | +1.2% | ➡️  |
| CompleteSuccessWorkflow | 7.006 ns | 7.158 ns | +2.2% | ➡️  |
| CompleteFailureWorkflow | 8.477 ns | 9.266 ns | +9.3% | ⚠️ MINOR |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.0/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 24.2/0.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 4.0/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/0.4 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.6/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.3/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.7/7.7 | ➡️  |

## Regressions

### CreateSuccessResult_String - MINOR

- **Baseline**: 7.480 ns (24 B allocated)
- **Current**: 7.865 ns (24 B allocated)
- **Change**: +5.1%
- **Recommendation**: Monitor

### CompleteFailureWorkflow - MINOR

- **Baseline**: 8.477 ns (24 B allocated)
- **Current**: 9.266 ns (24 B allocated)
- **Change**: +9.3%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **2 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
