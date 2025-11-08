# Performance Review Results

**Date**: 2025-11-08 19:16:39 UTC
**Baseline**: 2025-11-08T18:39:31.125224
**Commit**: 

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 0
- **Improvements**: 0
- **Status**: ✅ PASS

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.366 ns | 7.501 ns | +1.8% | ➡️  |
| CreateSuccessResult_Int | 7.620 ns | 7.422 ns | -2.6% | ➡️  |
| CreateSuccessResult_Unit | 7.869 ns | 8.054 ns | +2.4% | ➡️  |
| CreateFailureResult_String | 9.437 ns | 9.699 ns | +2.8% | ➡️  |
| CreateFailureResult_Int | 9.059 ns | 9.043 ns | -0.2% | ➡️  |
| CreateFailureResult_Unit | 9.052 ns | 9.059 ns | +0.1% | ➡️  |
| GetValue_Success | 9.586 ns | 9.286 ns | -3.1% | ➡️  |
| GetError_Failure | 8.765 ns | 8.776 ns | +0.1% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.824 ns | 8.846 ns | +0.2% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.868 ns | 7.133 ns | +3.9% | ➡️  |
| CompleteSuccessWorkflow | 7.201 ns | 7.006 ns | -2.7% | ➡️  |
| CompleteFailureWorkflow | 8.711 ns | 8.729 ns | +0.2% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.0/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 24.2/0.2 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.9/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.5/3.5 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.2/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/10.1 | ➡️  |

## Action Items

- [x] No regressions detected
- [x] Baseline will be automatically updated

## Conclusion

✅ **All benchmarks passed.** Performance is within acceptable range of baseline.
