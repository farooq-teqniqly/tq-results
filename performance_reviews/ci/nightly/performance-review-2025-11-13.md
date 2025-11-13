# Performance Review Results

**Date**: 2025-11-13 17:51:21 UTC
**Baseline**: 2025-11-13T05:39:24.824336
**Commit**: a6be5e03af539218dbfe466034c1dc9570cff101

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 0
- **Improvements**: 1
- **Status**: ✅ PASS

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 14.829 ns | 7.826 ns | -47.2% | ✅  |
| CreateSuccessResult_Int | 7.658 ns | 7.501 ns | -2.1% | ➡️  |
| CreateSuccessResult_Unit | 7.967 ns | 7.938 ns | -0.4% | ➡️  |
| CreateFailureResult_String | 9.559 ns | 9.480 ns | -0.8% | ➡️  |
| CreateFailureResult_Int | 9.552 ns | 9.100 ns | -4.7% | ➡️  |
| CreateFailureResult_Unit | 9.191 ns | 9.047 ns | -1.6% | ➡️  |
| GetValue_Success | 9.446 ns | 9.019 ns | -4.5% | ➡️  |
| GetError_Failure | 8.880 ns | 8.795 ns | -1.0% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 9.191 ns | 8.906 ns | -3.1% | ➡️  |
| CheckIsFailure_OnFailureResult | 7.007 ns | 7.227 ns | +3.1% | ➡️  |
| CompleteSuccessWorkflow | 7.162 ns | 7.431 ns | +3.8% | ➡️  |
| CompleteFailureWorkflow | 8.850 ns | 8.767 ns | -0.9% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.0/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 23.9/0.2 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.9/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 24.4/0.1 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.1/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/9.9 | ➡️  |

## Action Items

- [x] No regressions detected
- [x] Baseline will be automatically updated

## Conclusion

✅ **All benchmarks passed.** Performance is within acceptable range of baseline.
