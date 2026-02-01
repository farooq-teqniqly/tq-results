# Performance Review Results

**Date**: 2026-02-01 22:48:50 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 4a5d2b0ac20d6165e0095b077026827bc0e4009c

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 1
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.360 ns | -4.5% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.356 ns | -2.1% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 8.046 ns | +1.5% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.484 ns | -0.2% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.178 ns | -0.4% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.154 ns | +0.5% | ➡️  |
| GetValue_Success | 9.663 ns | 9.066 ns | -6.2% | ✅  |
| GetError_Failure | 8.830 ns | 9.010 ns | +2.0% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.923 ns | +0.1% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.929 ns | -0.3% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 7.264 ns | +15.0% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.818 ns | -2.6% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.0/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.7/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/3.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.7/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 2.1/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.7/7.7 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 7.264 ns (24 B allocated)
- **Change**: +15.0%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
