# Performance Review Results

**Date**: 2026-04-12 22:52:15 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 0b2e5fecacb39b5091fc2b6be399e2e5174fec6c

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.339 ns | -4.8% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.488 ns | -0.3% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.902 ns | -0.3% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.504 ns | -0.0% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.104 ns | -1.2% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.108 ns | -0.0% | ➡️  |
| GetValue_Success | 9.663 ns | 9.362 ns | -3.1% | ➡️  |
| GetError_Failure | 8.830 ns | 8.819 ns | -0.1% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.903 ns | -0.1% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.922 ns | -0.4% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.667 ns | +5.5% | ⚠️ MINOR |
| CompleteFailureWorkflow | 9.057 ns | 8.767 ns | -3.2% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.0/2.7 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 24.2/0.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 9.2/0.0 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.0/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.4/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/10.0 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.667 ns (24 B allocated)
- **Change**: +5.5%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
