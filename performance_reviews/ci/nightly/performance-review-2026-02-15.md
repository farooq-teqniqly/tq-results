# Performance Review Results

**Date**: 2026-02-15 22:48:56 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: bc0a19627bf671305a424788ed2ded008fa146e5

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.918 ns | +2.7% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.542 ns | +0.4% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.940 ns | +0.2% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.507 ns | +0.0% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.439 ns | +2.4% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.397 ns | +3.1% | ➡️  |
| GetValue_Success | 9.663 ns | 9.375 ns | -3.0% | ➡️  |
| GetError_Failure | 8.830 ns | 8.811 ns | -0.2% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.913 ns | -0.0% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.935 ns | -0.2% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 7.081 ns | +12.1% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.784 ns | -3.0% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.4/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 10.7/2.0 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 9.2/0.0 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 9.6/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.1/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/10.0 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 7.081 ns (24 B allocated)
- **Change**: +12.1%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
