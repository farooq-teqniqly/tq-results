# Performance Review Results

**Date**: 2026-04-26 22:53:00 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 28f0639842136cc97d857ed478065bb7cce57aae

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 1
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.550 ns | -2.1% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.445 ns | -0.9% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.937 ns | +0.1% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.456 ns | -0.5% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.042 ns | -1.9% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 8.969 ns | -1.6% | ➡️  |
| GetValue_Success | 9.663 ns | 8.979 ns | -7.1% | ✅  |
| GetError_Failure | 8.830 ns | 8.839 ns | +0.1% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.816 ns | -1.1% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.867 ns | -1.2% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.979 ns | +10.5% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.999 ns | -0.6% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.2/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.6/2.0 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.4/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.4/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.5/9.9 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.979 ns (24 B allocated)
- **Change**: +10.5%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
