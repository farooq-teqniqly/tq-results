# Performance Review Results

**Date**: 2025-11-07 23:56:03 UTC
**Baseline**: 2025-11-07T01:16:16.472257
**Commit**: 

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 10
- **Improvements**: 2
- **Status**: ⚠️ REGRESSIONS FOUND (CRITICAL)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.354 ns | 8.150 ns | +10.8% | ⚠️ MAJOR |
| CreateSuccessResult_Int | 7.237 ns | 8.195 ns | +13.2% | ⚠️ MAJOR |
| CreateSuccessResult_Unit | 17.208 ns | 8.891 ns | -48.3% | ✅  |
| CreateFailureResult_String | 8.954 ns | 11.067 ns | +23.6% | ⚠️ CRITICAL |
| CreateFailureResult_Int | 8.824 ns | 9.925 ns | +12.5% | ⚠️ MAJOR |
| CreateFailureResult_Unit | 9.120 ns | 9.894 ns | +8.5% | ⚠️ MINOR |
| GetValue_Success | 9.014 ns | 10.125 ns | +12.3% | ⚠️ MAJOR |
| GetError_Failure | 7.971 ns | 9.405 ns | +18.0% | ⚠️ MAJOR |
| CheckIsSuccess_OnSuccessResult | 8.483 ns | 9.403 ns | +10.8% | ⚠️ MAJOR |
| CheckIsFailure_OnFailureResult | 6.605 ns | 7.301 ns | +10.5% | ⚠️ MAJOR |
| CompleteSuccessWorkflow | 13.194 ns | 7.152 ns | -45.8% | ✅  |
| CompleteFailureWorkflow | 8.140 ns | 9.517 ns | +16.9% | ⚠️ MAJOR |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 7.7/1.2 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 6.1/1.0 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 9.2/0.0 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 7.9/1.2 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 6.2/1.1 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.0/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 8.0/1.2 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 17.1/5.2 | ➡️  |

## Regressions

### CreateSuccessResult_String - MAJOR

- **Baseline**: 7.354 ns (24 B allocated)
- **Current**: 8.150 ns (24 B allocated)
- **Change**: +10.8%
- **Recommendation**: Investigate

### CreateSuccessResult_Int - MAJOR

- **Baseline**: 7.237 ns (24 B allocated)
- **Current**: 8.195 ns (24 B allocated)
- **Change**: +13.2%
- **Recommendation**: Investigate

### CreateFailureResult_String - CRITICAL

- **Baseline**: 8.954 ns (24 B allocated)
- **Current**: 11.067 ns (24 B allocated)
- **Change**: +23.6%
- **Recommendation**: Fix before merge

### CreateFailureResult_Int - MAJOR

- **Baseline**: 8.824 ns (24 B allocated)
- **Current**: 9.925 ns (24 B allocated)
- **Change**: +12.5%
- **Recommendation**: Investigate

### CreateFailureResult_Unit - MINOR

- **Baseline**: 9.120 ns (24 B allocated)
- **Current**: 9.894 ns (24 B allocated)
- **Change**: +8.5%
- **Recommendation**: Monitor

### GetValue_Success - MAJOR

- **Baseline**: 9.014 ns (24 B allocated)
- **Current**: 10.125 ns (24 B allocated)
- **Change**: +12.3%
- **Recommendation**: Investigate

### GetError_Failure - MAJOR

- **Baseline**: 7.971 ns (24 B allocated)
- **Current**: 9.405 ns (24 B allocated)
- **Change**: +18.0%
- **Recommendation**: Investigate

### CheckIsSuccess_OnSuccessResult - MAJOR

- **Baseline**: 8.483 ns (24 B allocated)
- **Current**: 9.403 ns (24 B allocated)
- **Change**: +10.8%
- **Recommendation**: Investigate

### CheckIsFailure_OnFailureResult - MAJOR

- **Baseline**: 6.605 ns (24 B allocated)
- **Current**: 7.301 ns (24 B allocated)
- **Change**: +10.5%
- **Recommendation**: Investigate

### CompleteFailureWorkflow - MAJOR

- **Baseline**: 8.140 ns (24 B allocated)
- **Current**: 9.517 ns (24 B allocated)
- **Change**: +16.9%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **10 regression(s) detected with CRITICAL severity.** Please review and address before baseline is updated.
