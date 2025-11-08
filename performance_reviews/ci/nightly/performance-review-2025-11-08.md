# Performance Review Results

**Date**: 2025-11-08 21:13:49 UTC
**Baseline**: 2025-11-08T19:16:39.731498
**Commit**: 60ff88cd309ea774c7a15dbe762c95d0a1f2283a

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 1
- **Improvements**: 1
- **Status**: ⚠️ REGRESSIONS FOUND (MAJOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.501 ns | 7.496 ns | -0.1% | ➡️  |
| CreateSuccessResult_Int | 7.422 ns | 7.632 ns | +2.8% | ➡️  |
| CreateSuccessResult_Unit | 8.054 ns | 7.859 ns | -2.4% | ➡️  |
| CreateFailureResult_String | 9.699 ns | 9.444 ns | -2.6% | ➡️  |
| CreateFailureResult_Int | 9.043 ns | 9.064 ns | +0.2% | ➡️  |
| CreateFailureResult_Unit | 9.059 ns | 9.107 ns | +0.5% | ➡️  |
| GetValue_Success | 9.286 ns | 9.278 ns | -0.1% | ➡️  |
| GetError_Failure | 8.776 ns | 9.757 ns | +11.2% | ⚠️ MAJOR |
| CheckIsSuccess_OnSuccessResult | 8.846 ns | 8.832 ns | -0.2% | ➡️  |
| CheckIsFailure_OnFailureResult | 7.133 ns | 6.867 ns | -3.7% | ➡️  |
| CompleteSuccessWorkflow | 7.006 ns | 6.647 ns | -5.1% | ✅  |
| CompleteFailureWorkflow | 8.729 ns | 8.758 ns | +0.3% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.2/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.5/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 9.2/0.0 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 9.3/1.3 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/3.0 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.4/10.1 | ➡️  |

## Regressions

### GetError_Failure - MAJOR

- **Baseline**: 8.776 ns (24 B allocated)
- **Current**: 9.757 ns (24 B allocated)
- **Change**: +11.2%
- **Recommendation**: Investigate


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **1 regression(s) detected with MAJOR severity.** Please review and address before baseline is updated.
