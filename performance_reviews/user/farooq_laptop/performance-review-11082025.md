# Performance Review Results - Initial Baseline

**Date**: 2025-11-08 12:31:37 UTC
**Baseline**: Initial Run
**Commit**: f4b494eeade680b1ae621e03605a5f09966ffd4f

## Summary

This is the **initial benchmark run**. No baseline exists for comparison.

- **Total Benchmarks**: 23
- **Status**: ✅ INITIAL BASELINE ESTABLISHED

## Benchmarks Recorded

The following benchmarks will serve as the baseline for future comparisons:


### CPU Benchmarks

- **CreateSuccessResult_String**: 4.186 ns (24 B)
- **CreateSuccessResult_Int**: 5.760 ns (0 B)
- **CreateSuccessResult_Unit**: 5.716 ns (232 B)
- **CreateFailureResult_String**: 6.937 ns (0 B)
- **CreateFailureResult_Int**: 6.383 ns (0 B)
- **CreateFailureResult_Unit**: 6.379 ns (24 B)
- **GetValue_Success**: 6.386 ns (24 B)
- **GetError_Failure**: 6.331 ns (24 B)
- **CheckIsSuccess_OnSuccessResult**: 5.585 ns (24 B)
- **CheckIsFailure_OnFailureResult**: 3.484 ns (24 B)
- **CompleteSuccessWorkflow**: 3.113 ns (24 B)
- **CompleteFailureWorkflow**: 5.728 ns (24 B)
- **NestedResults**: 12.000 ns (187 B)

### Memory Benchmarks

- **CreateAndStoreResultsInArray**: 44926.330 ns (84,024 B, Gen0/1: 0.1/0.0)
- **CreateAndStoreResultsInList**: 29894.320 ns (64,056 B, Gen0/1: 0.4/0.0)
- **ReuseSuccessResult**: 5684.320 ns (24 B, Gen0/1: 0.0/0.0)
- **ReuseErrorInstance**: 10835.960 ns (0 B, Gen0/1: 0.0/0.0)
- **CreateNewErrorInstances**: 46056.400 ns (88,000 B, Gen0/1: 0.2/0.0)
- **CreateNewValueInstances**: 41024.020 ns (64,000 B, Gen0/1: 0.0/0.0)
- **ChainedResultProcessing**: 165.430 ns (1,482 B, Gen0/1: 0.0/0.0)
- **ResultWithLargeValue**: 553.140 ns (10,048 B, Gen0/1: 0.0/0.0)
- **FilterResults**: 51129.390 ns (86,024 B, Gen0/1: 0.4/0.0)
- **ResultsInDictionary**: 86438.160 ns (198,136 B, Gen0/1: 1.3/0.0)

## Next Steps

- [x] Initial baseline established
- [x] Future runs will compare against this baseline
- [x] Performance regressions will be automatically detected

## Conclusion

✅ **Initial baseline successfully established.** Future benchmark runs will compare against these values.
