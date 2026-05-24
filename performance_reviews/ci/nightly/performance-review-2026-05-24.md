# Performance Review Results

**Date**: 2026-05-24 22:55:21 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: a487e46f543d1af644d9933fb50f008f3a283429

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 2
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.502 ns | -2.7% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.482 ns | -0.4% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.889 ns | -0.5% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.511 ns | +0.1% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.078 ns | -1.5% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 10.011 ns | +9.9% | ⚠️ MINOR |
| GetValue_Success | 9.663 ns | 9.324 ns | -3.5% | ➡️  |
| GetError_Failure | 8.830 ns | 8.820 ns | -0.1% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.821 ns | -1.1% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.867 ns | -1.2% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.991 ns | +10.7% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.740 ns | -3.5% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.2/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 22.6/0.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.3 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.1/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/9.9 | ➡️  |

## Regressions

### CreateFailureResult_Unit - MINOR

- **Baseline**: 9.112 ns (24 B allocated)
- **Current**: 10.011 ns (24 B allocated)
- **Change**: +9.9%
- **Recommendation**: Monitor

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.991 ns (24 B allocated)
- **Change**: +10.7%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **2 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
