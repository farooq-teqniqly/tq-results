# Performance Review Results

**Date**: 2025-11-16 22:43:30 UTC
**Baseline**: 2025-11-13T17:51:21.730662
**Commit**: 7d720f55c7d7ec73ba7747a5155aab4e9de8aa24

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 0
- **Improvements**: 0
- **Status**: ✅ PASS

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.826 ns | 7.645 ns | -2.3% | ➡️  |
| CreateSuccessResult_Int | 7.501 ns | 7.416 ns | -1.1% | ➡️  |
| CreateSuccessResult_Unit | 7.938 ns | 7.996 ns | +0.7% | ➡️  |
| CreateFailureResult_String | 9.480 ns | 9.560 ns | +0.8% | ➡️  |
| CreateFailureResult_Int | 9.100 ns | 9.196 ns | +1.1% | ➡️  |
| CreateFailureResult_Unit | 9.047 ns | 9.183 ns | +1.5% | ➡️  |
| GetValue_Success | 9.019 ns | 9.112 ns | +1.0% | ➡️  |
| GetError_Failure | 8.795 ns | 9.167 ns | +4.2% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.906 ns | 8.957 ns | +0.6% | ➡️  |
| CheckIsFailure_OnFailureResult | 7.227 ns | 7.011 ns | -3.0% | ➡️  |
| CompleteSuccessWorkflow | 7.431 ns | 7.151 ns | -3.8% | ➡️  |
| CompleteFailureWorkflow | 8.767 ns | 8.918 ns | +1.7% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.1/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 11.6/2.1 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.6/1.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.0/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.0/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.8/7.6 | ➡️  |

## Action Items

- [x] No regressions detected
- [x] Baseline will be automatically updated

## Conclusion

✅ **All benchmarks passed.** Performance is within acceptable range of baseline.
