# Performance Review Results

**Date**: 2025-11-07 20:28:24 UTC
**Baseline**: 2025-11-07T01:16:16.472257
**Commit**: 

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 3
- **Improvements**: 2
- **Status**: ⚠️ REGRESSIONS FOUND (CRITICAL)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.354 ns | 7.643 ns | +3.9% | ➡️  |
| CreateSuccessResult_Int | 7.237 ns | 15.108 ns | +108.8% | ⚠️ CRITICAL |
| CreateSuccessResult_Unit | 17.208 ns | 15.790 ns | -8.2% | ✅  |
| CreateFailureResult_String | 8.954 ns | 9.417 ns | +5.2% | ⚠️ MINOR |
| CreateFailureResult_Int | 8.824 ns | 9.198 ns | +4.2% | ➡️  |
| CreateFailureResult_Unit | 9.120 ns | 9.165 ns | +0.5% | ➡️  |
| GetValue_Success | 9.014 ns | 9.246 ns | +2.6% | ➡️  |
| GetError_Failure | 7.971 ns | 8.126 ns | +1.9% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.483 ns | 8.672 ns | +2.2% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.605 ns | 6.818 ns | +3.2% | ➡️  |
| CompleteSuccessWorkflow | 13.194 ns | 10.108 ns | -23.4% | ✅  |
| CompleteFailureWorkflow | 8.140 ns | 9.249 ns | +13.6% | ⚠️ MAJOR |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 5.0/1.2 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 3.8/0.7 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 1.4/0.1 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 5.2/1.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 3.8/0.7 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.0/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 0.6/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 5.1/1.0 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 11.7/5.7 | ➡️  |

## Regressions

### CreateSuccessResult_Int - CRITICAL

- **Baseline**: 7.237 ns (24 B allocated)
- **Current**: 15.108 ns (24 B allocated)
- **Change**: +108.8%
- **Recommendation**: Fix before merge

### CreateFailureResult_String - MINOR

- **Baseline**: 8.954 ns (24 B allocated)
- **Current**: 9.417 ns (24 B allocated)
- **Change**: +5.2%
- **Recommendation**: Monitor

### CompleteFailureWorkflow - MAJOR

- **Baseline**: 8.140 ns (24 B allocated)
- **Current**: 9.249 ns (24 B allocated)
- **Change**: +13.6%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **3 regression(s) detected with CRITICAL severity.** Please review and address before baseline is updated.
