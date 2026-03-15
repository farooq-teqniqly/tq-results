# Performance Review Results

**Date**: 2026-03-15 22:50:41 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: b142c38904b0637423185179ad0bab06aabf44b5

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.589 ns | -1.6% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.355 ns | -2.1% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.989 ns | +0.8% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.576 ns | +0.7% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.141 ns | -0.8% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.162 ns | +0.5% | ➡️  |
| GetValue_Success | 9.663 ns | 9.408 ns | -2.6% | ➡️  |
| GetError_Failure | 8.830 ns | 9.164 ns | +3.8% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.949 ns | +0.4% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 7.010 ns | +0.9% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 7.087 ns | +12.2% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.857 ns | -2.2% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.2/2.7 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.6/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.7/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.0/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 2.1/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.1/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.7/7.5 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 7.087 ns (24 B allocated)
- **Change**: +12.2%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
