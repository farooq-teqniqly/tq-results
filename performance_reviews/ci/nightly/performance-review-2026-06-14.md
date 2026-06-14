# Performance Review Results

**Date**: 2026-06-14 23:00:12 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: 59fc5c134bbac204f20fc3b165caad07929fe40c

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 1
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.632 ns | -1.0% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.558 ns | +0.6% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 7.982 ns | +0.7% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.554 ns | +0.5% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.152 ns | -0.7% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.155 ns | +0.5% | ➡️  |
| GetValue_Success | 9.663 ns | 9.100 ns | -5.8% | ✅  |
| GetError_Failure | 8.830 ns | 8.860 ns | +0.3% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 8.946 ns | +0.3% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 6.989 ns | +0.6% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 7.119 ns | +12.7% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.834 ns | -2.5% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.0/2.7 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.7/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.9/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/3.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 9.8/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.4/3.0 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.5/10.0 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 7.119 ns (24 B allocated)
- **Change**: +12.7%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
