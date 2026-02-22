# Performance Review Results

**Date**: 2026-02-22 22:49:02 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 4182c390c6342b2e9b5a0c2cd3bdf552a7235000

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 2
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.339 ns | -4.8% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.528 ns | +0.2% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 8.130 ns | +2.5% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.540 ns | +0.4% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.750 ns | +5.8% | ⚠️ MINOR |
| CreateFailureResult_Unit | 9.112 ns | 9.150 ns | +0.4% | ➡️  |
| GetValue_Success | 9.663 ns | 9.397 ns | -2.8% | ➡️  |
| GetError_Failure | 8.830 ns | 8.883 ns | +0.6% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 9.062 ns | +1.6% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.949 ns | 0.0% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 7.088 ns | +12.2% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.837 ns | -2.4% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.1/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.6/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/3.8 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.3/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/7.6 | ➡️  |

## Regressions

### CreateFailureResult_Int - MINOR

- **Baseline**: 9.216 ns (24 B allocated)
- **Current**: 9.750 ns (24 B allocated)
- **Change**: +5.8%
- **Recommendation**: Monitor

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 7.088 ns (24 B allocated)
- **Change**: +12.2%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **2 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
