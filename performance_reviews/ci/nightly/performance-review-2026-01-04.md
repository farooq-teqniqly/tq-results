# Performance Review Results

**Date**: 2026-01-04 22:45:12 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 89a75cbb9b024fbdf8a9975c350d2adb2a5340fc

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 1
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.604 ns | -1.4% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.591 ns | +1.1% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 8.177 ns | +3.1% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.558 ns | +0.6% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.447 ns | +2.5% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.209 ns | +1.1% | ➡️  |
| GetValue_Success | 9.663 ns | 9.177 ns | -5.0% | ✅  |
| GetError_Failure | 8.830 ns | 9.132 ns | +3.4% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.961 ns | +0.5% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 7.017 ns | +1.0% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.735 ns | +6.6% | ⚠️ MINOR |
| CompleteFailureWorkflow | 9.057 ns | 8.877 ns | -2.0% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.0/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 20.2/0.2 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.3/1.3 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 32.4/0.1 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/10.1 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.735 ns (24 B allocated)
- **Change**: +6.6%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
