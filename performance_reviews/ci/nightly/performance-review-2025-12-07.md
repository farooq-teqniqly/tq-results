# Performance Review Results

**Date**: 2025-12-07 22:43:23 UTC
**Baseline**: 2025-11-23T22:43:54.051505
**Commit**: 5b70d28b6796290b995cde53d30def3216110673

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 0
- **Improvements**: 1
- **Status**: ✅ PASS

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.565 ns | 7.709 ns | +1.9% | ➡️  |
| CreateSuccessResult_Int | 7.506 ns | 7.511 ns | +0.1% | ➡️  |
| CreateSuccessResult_Unit | 7.932 ns | 7.928 ns | -0.1% | ➡️  |
| CreateFailureResult_String | 9.490 ns | 9.505 ns | +0.2% | ➡️  |
| CreateFailureResult_Int | 9.136 ns | 9.216 ns | +0.9% | ➡️  |
| CreateFailureResult_Unit | 9.073 ns | 9.112 ns | +0.4% | ➡️  |
| GetValue_Success | 9.350 ns | 9.663 ns | +3.3% | ➡️  |
| GetError_Failure | 8.861 ns | 8.830 ns | -0.3% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 9.043 ns | 8.915 ns | -1.4% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.936 ns | 6.949 ns | +0.2% | ➡️  |
| CompleteSuccessWorkflow | 7.190 ns | 6.318 ns | -12.1% | ✅  |
| CompleteFailureWorkflow | 9.004 ns | 9.057 ns | +0.6% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.3/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 23.3/0.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.9/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.1/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.1/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/10.0 | ➡️  |

## Action Items

- [x] No regressions detected
- [x] Baseline will be automatically updated

## Conclusion

✅ **All benchmarks passed.** Performance is within acceptable range of baseline.
