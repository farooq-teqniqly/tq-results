# Performance Review Results

**Date**: 2026-03-01 22:47:41 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 34d167ab29625a34d86257d1da551799964659e1

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (CRITICAL)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.522 ns | -2.4% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.547 ns | +0.5% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.922 ns | -0.1% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.476 ns | -0.3% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.109 ns | -1.2% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.330 ns | +2.4% | ➡️  |
| GetValue_Success | 9.663 ns | 9.399 ns | -2.7% | ➡️  |
| GetError_Failure | 8.830 ns | 9.076 ns | +2.8% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 9.061 ns | +1.6% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.938 ns | -0.2% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 9.707 ns | +53.6% | ⚠️ CRITICAL |
| CompleteFailureWorkflow | 9.057 ns | 8.797 ns | -2.9% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.4/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.6/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.6/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.1/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.5/10.1 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - CRITICAL

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 9.707 ns (24 B allocated)
- **Change**: +53.6%
- **Recommendation**: Fix before merge


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with CRITICAL severity.** Please review and address before baseline is updated.
