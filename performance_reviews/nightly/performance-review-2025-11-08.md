# Performance Review Results

**Date**: 2025-11-08 03:02:46 UTC
**Baseline**: 2025-11-08T01:41:19.747573
**Commit**: 

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 5
- **Improvements**: 1
- **Status**: ⚠️ REGRESSIONS FOUND (CRITICAL)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 6.666 ns | 6.501 ns | -2.5% | ➡️  |
| CreateSuccessResult_Int | 16.226 ns | 7.627 ns | -53.0% | ✅  |
| CreateSuccessResult_Unit | 12.673 ns | 12.289 ns | -3.0% | ➡️  |
| CreateFailureResult_String | 8.071 ns | 9.120 ns | +13.0% | ⚠️ MAJOR |
| CreateFailureResult_Int | 8.862 ns | 8.454 ns | -4.6% | ➡️  |
| CreateFailureResult_Unit | 8.181 ns | 9.208 ns | +12.6% | ⚠️ MAJOR |
| GetValue_Success | 8.468 ns | 8.321 ns | -1.7% | ➡️  |
| GetError_Failure | 8.120 ns | 7.882 ns | -2.9% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.431 ns | 8.246 ns | -2.2% | ➡️  |
| CheckIsFailure_OnFailureResult | 5.450 ns | 6.330 ns | +16.1% | ⚠️ MAJOR |
| CompleteSuccessWorkflow | 6.523 ns | 9.392 ns | +44.0% | ⚠️ CRITICAL |
| CompleteFailureWorkflow | 7.599 ns | 8.249 ns | +8.6% | ⚠️ MINOR |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 4.8/1.0 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 3.8/0.7 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 1.4/0.1 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 5.2/1.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 3.7/0.7 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.0/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 0.6/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 4.9/1.0 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 11.7/5.7 | ➡️  |

## Regressions

### CreateFailureResult_String - MAJOR

- **Baseline**: 8.071 ns (24 B allocated)
- **Current**: 9.120 ns (24 B allocated)
- **Change**: +13.0%
- **Recommendation**: Investigate

### CreateFailureResult_Unit - MAJOR

- **Baseline**: 8.181 ns (24 B allocated)
- **Current**: 9.208 ns (24 B allocated)
- **Change**: +12.6%
- **Recommendation**: Investigate

### CheckIsFailure_OnFailureResult - MAJOR

- **Baseline**: 5.450 ns (24 B allocated)
- **Current**: 6.330 ns (24 B allocated)
- **Change**: +16.1%
- **Recommendation**: Investigate

### CompleteSuccessWorkflow - CRITICAL

- **Baseline**: 6.523 ns (24 B allocated)
- **Current**: 9.392 ns (24 B allocated)
- **Change**: +44.0%
- **Recommendation**: Fix before merge

### CompleteFailureWorkflow - MINOR

- **Baseline**: 7.599 ns (24 B allocated)
- **Current**: 8.249 ns (24 B allocated)
- **Change**: +8.6%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **5 regression(s) detected with CRITICAL severity.** Please review and address before baseline is updated.
