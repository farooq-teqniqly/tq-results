# Performance Review Results

**Date**: 2026-03-08 22:47:54 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: a5f154cbe6520ee0fc5aaad94e92360e795dff96

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 1
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 6.910 ns | -10.4% | ✅  |
| CreateSuccessResult_Int | 7.511 ns | 7.774 ns | +3.5% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 8.205 ns | +3.5% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.594 ns | +0.9% | ➡️  |
| CreateFailureResult_Int | 9.216 ns | 9.216 ns | 0.0% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.192 ns | +0.9% | ➡️  |
| GetValue_Success | 9.663 ns | 9.456 ns | -2.1% | ➡️  |
| GetError_Failure | 8.830 ns | 8.914 ns | +1.0% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 9.118 ns | +2.3% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 7.006 ns | +0.8% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 7.108 ns | +12.5% | ⚠️ MAJOR |
| CompleteFailureWorkflow | 9.057 ns | 8.879 ns | -2.0% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.3/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.7/2.0 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.9/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.8 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.4/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 2.1/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 31.7/0.4 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/10.0 | ➡️  |

## Regressions

### CompleteSuccessWorkflow - MAJOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 7.108 ns (24 B allocated)
- **Change**: +12.5%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
