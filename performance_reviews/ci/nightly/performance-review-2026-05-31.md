# Performance Review Results

**Date**: 2026-05-31 22:55:30 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 0f5f053a8a4f1464d2bdd15d9f01675adac34b43

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.609 ns | -1.3% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.638 ns | +1.7% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.984 ns | +0.7% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.503 ns | -0.0% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.117 ns | -1.1% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.149 ns | +0.4% | ➡️  |
| GetValue_Success | 9.663 ns | 9.397 ns | -2.8% | ➡️  |
| GetError_Failure | 8.830 ns | 8.878 ns | +0.5% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.938 ns | +0.3% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.973 ns | +0.3% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.715 ns | +6.3% | ⚠️ MINOR |
| CompleteFailureWorkflow | 9.057 ns | 8.732 ns | -3.6% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.4/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.6/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.2/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.1/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/9.9 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.715 ns (24 B allocated)
- **Change**: +6.3%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
