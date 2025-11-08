# Performance Review Results

**Date**: 2025-11-08 21:23:22 UTC
**Baseline**: 2025-11-08T19:16:39.731498
**Commit**: 1f43d193e98b26eb2a0ed75d9158787fde12121f

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (CRITICAL)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.501 ns | 7.536 ns | +0.5% | ➡️  |
| CreateSuccessResult_Int | 7.422 ns | 14.583 ns | +96.5% | ⚠️ CRITICAL |
| CreateSuccessResult_Unit | 8.054 ns | 7.976 ns | -1.0% | ➡️  |
| CreateFailureResult_String | 9.699 ns | 9.425 ns | -2.8% | ➡️  |
| CreateFailureResult_Int | 9.043 ns | 9.018 ns | -0.3% | ➡️  |
| CreateFailureResult_Unit | 9.059 ns | 9.023 ns | -0.4% | ➡️  |
| GetValue_Success | 9.286 ns | 9.296 ns | +0.1% | ➡️  |
| GetError_Failure | 8.776 ns | 8.778 ns | +0.0% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.846 ns | 8.812 ns | -0.4% | ➡️  |
| CheckIsFailure_OnFailureResult | 7.133 ns | 7.026 ns | -1.5% | ➡️  |
| CompleteSuccessWorkflow | 7.006 ns | 6.986 ns | -0.3% | ➡️  |
| CompleteFailureWorkflow | 8.729 ns | 8.729 ns | 0.0% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.1/3.0 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.7/2.0 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 9.2/0.0 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.5/3.2 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.3/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.0/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.4/9.9 | ➡️  |

## Regressions

### CreateSuccessResult_Int - CRITICAL

- **Baseline**: 7.422 ns (24 B allocated)
- **Current**: 14.583 ns (24 B allocated)
- **Change**: +96.5%
- **Recommendation**: Fix before merge


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with CRITICAL severity.** Please review and address before baseline is updated.
