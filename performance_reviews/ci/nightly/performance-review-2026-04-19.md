# Performance Review Results

**Date**: 2026-04-19 22:52:22 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: f5293676123d863cfe6da9ad45793f0cfaba5447

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 2
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.527 ns | -2.4% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.304 ns | -2.8% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.737 ns | -2.4% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.378 ns | -1.3% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 10.023 ns | +8.8% | ⚠️ MINOR |
| CreateFailureResult_Unit | 9.112 ns | 9.156 ns | +0.5% | ➡️  |
| GetValue_Success | 9.663 ns | 9.325 ns | -3.5% | ➡️  |
| GetError_Failure | 8.830 ns | 8.782 ns | -0.5% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.881 ns | -0.4% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.909 ns | -0.6% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 7.044 ns | +11.5% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.761 ns | -3.3% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 27.0/0.1 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.6/2.0 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.9/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.4/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.4/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.7/7.6 | ➡️  |

## Regressions

### CreateFailureResult_Int - MINOR

- **Baseline**: 9.216 ns (24 B allocated)
- **Current**: 10.023 ns (24 B allocated)
- **Change**: +8.8%
- **Recommendation**: Monitor

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 7.044 ns (24 B allocated)
- **Change**: +11.5%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **2 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
