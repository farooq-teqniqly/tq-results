# Performance Review Results

**Date**: 2025-11-12 23:41:35 UTC
**Baseline**: 2025-11-11T17:15:55.936790
**Commit**: e528b82692c58a9bbb643c583befcb460402b20f

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 0
- **Improvements**: 1
- **Status**: ✅ PASS

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| ReuseSuccessResult | 8259.790 ns | 6570.220 ns | -20.5% | ✅  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateSuccessResult_String | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| CreateSuccessResult_Int | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| CreateSuccessResult_Unit | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| CreateFailureResult_String | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| CreateFailureResult_Int | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| CreateFailureResult_Unit | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| GetValue_Success | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| GetError_Failure | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| CheckIsSuccess_OnSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| CheckIsFailure_OnFailureResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| CompleteSuccessWorkflow | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| CompleteFailureWorkflow | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 13.9/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 12.2/2.2 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.7/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.6 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.8/1.5 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.2/2.9 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.7/7.7 | ➡️  |

## Action Items

- [x] No regressions detected
- [x] Baseline will be automatically updated

## Conclusion

✅ **All benchmarks passed.** Performance is within acceptable range of baseline.
