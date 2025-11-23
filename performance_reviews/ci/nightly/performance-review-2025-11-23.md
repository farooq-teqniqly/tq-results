# Performance Review Results

**Date**: 2025-11-23 22:43:54 UTC
**Baseline**: 2025-11-16T22:43:30.876290
**Commit**: 57f9b94a3d64365f0eddb0003b970a571596e154

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 0
- **Improvements**: 0
- **Status**: ✅ PASS

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.645 ns | 7.565 ns | -1.0% | ➡️  |
| CreateSuccessResult_Int | 7.416 ns | 7.506 ns | +1.2% | ➡️  |
| CreateSuccessResult_Unit | 7.996 ns | 7.932 ns | -0.8% | ➡️  |
| CreateFailureResult_String | 9.560 ns | 9.490 ns | -0.7% | ➡️  |
| CreateFailureResult_Int | 9.196 ns | 9.136 ns | -0.7% | ➡️  |
| CreateFailureResult_Unit | 9.183 ns | 9.073 ns | -1.2% | ➡️  |
| GetValue_Success | 9.112 ns | 9.350 ns | +2.6% | ➡️  |
| GetError_Failure | 9.167 ns | 8.861 ns | -3.3% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.957 ns | 9.043 ns | +1.0% | ➡️  |
| CheckIsFailure_OnFailureResult | 7.011 ns | 6.936 ns | -1.1% | ➡️  |
| CompleteSuccessWorkflow | 7.151 ns | 7.190 ns | +0.5% | ➡️  |
| CompleteFailureWorkflow | 8.918 ns | 9.004 ns | +1.0% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 13.9/2.9 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 21.8/0.2 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.8/3.7 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 9.6/1.4 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.6/10.1 | ➡️  |

## Action Items

- [x] No regressions detected
- [x] Baseline will be automatically updated

## Conclusion

✅ **All benchmarks passed.** Performance is within acceptable range of baseline.
