# Performance Review Results

**Date**: 2025-11-11 17:15:55 UTC
**Baseline**: 2025-11-08T21:44:25.559241
**Commit**: 1985bdec7d72b0acf0a105eeb8f2c425f4278b28

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 0
- **Improvements**: 0
- **Status**: ✅ PASS

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.480 ns | 7.580 ns | +1.3% | ➡️  |
| CreateSuccessResult_Int | 7.442 ns | 7.528 ns | +1.2% | ➡️  |
| CreateSuccessResult_Unit | 7.847 ns | 8.090 ns | +3.1% | ➡️  |
| CreateFailureResult_String | 9.418 ns | 9.492 ns | +0.8% | ➡️  |
| CreateFailureResult_Int | 9.047 ns | 9.171 ns | +1.4% | ➡️  |
| CreateFailureResult_Unit | 9.045 ns | 9.147 ns | +1.1% | ➡️  |
| GetValue_Success | 8.979 ns | 9.402 ns | +4.7% | ➡️  |
| GetError_Failure | 8.772 ns | 9.111 ns | +3.9% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.816 ns | 8.943 ns | +1.4% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.901 ns | 7.128 ns | +3.3% | ➡️  |
| CompleteSuccessWorkflow | 7.006 ns | 7.240 ns | +3.3% | ➡️  |
| CompleteFailureWorkflow | 8.477 ns | 8.808 ns | +3.9% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.2/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.7/2.0 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 24.4/0.1 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 2.1/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.7/7.6 | ➡️  |

## Action Items

- [x] No regressions detected
- [x] Baseline will be automatically updated

## Conclusion

✅ **All benchmarks passed.** Performance is within acceptable range of baseline.
