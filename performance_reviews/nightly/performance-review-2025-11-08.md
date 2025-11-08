# Performance Review Results - Initial Baseline

**Date**: 2025-11-08 18:39:31 UTC
**Baseline**: 2025-11-08T18:00:13.676691
**Commit**: 

## Summary

This is the **initial benchmark run**. No baseline exists for comparison.

- **Total Benchmarks**: 23
- **Status**: ✅ INITIAL BASELINE ESTABLISHED

## Benchmarks Recorded

The following benchmarks will serve as the baseline for future comparisons:


### CPU Benchmarks

- **CreateSuccessResult_String**: 7.366 ns (24 B)
- **CreateSuccessResult_Int**: 7.620 ns (24 B)
- **CreateSuccessResult_Unit**: 7.869 ns (24 B)
- **CreateFailureResult_String**: 9.437 ns (24 B)
- **CreateFailureResult_Int**: 9.059 ns (24 B)
- **CreateFailureResult_Unit**: 9.052 ns (24 B)
- **GetValue_Success**: 9.586 ns (24 B)
- **GetError_Failure**: 8.765 ns (24 B)
- **CheckIsSuccess_OnSuccessResult**: 8.824 ns (24 B)
- **CheckIsFailure_OnFailureResult**: 6.868 ns (24 B)
- **CompleteSuccessWorkflow**: 7.201 ns (24 B)
- **CompleteFailureWorkflow**: 8.711 ns (24 B)

### Memory Benchmarks

- **CreateAndStoreResultsInArray**: 51887.790 ns (84,024 B, Gen0/1: 13.9/2.8)
- **CreateAndStoreResultsInList**: 37146.010 ns (64,056 B, Gen0/1: 11.5/2.1)
- **ReuseSuccessResult**: 6671.120 ns (24 B, Gen0/1: 0.0/0.0)
- **ReuseErrorInstance**: 13791.000 ns (24,024 B, Gen0/1: 3.8/0.3)
- **CreateNewErrorInstances**: 54808.750 ns (88,000 B, Gen0/1: 15.7/3.8)
- **CreateNewValueInstances**: 48851.780 ns (64,000 B, Gen0/1: 9.9/1.4)
- **ChainedResultProcessing**: 200.700 ns (376 B, Gen0/1: 0.1/0.0)
- **NestedResults**: 14.110 ns (48 B, Gen0/1: 0.0/0.0)
- **ResultWithLargeValue**: 696.320 ns (10,048 B, Gen0/1: 3.8/0.0)
- **FilterResults**: 46561.140 ns (86,024 B, Gen0/1: 15.3/3.0)
- **ResultsInDictionary**: 97707.980 ns (198,136 B, Gen0/1: 30.8/7.6)

## Next Steps

- [x] Initial baseline established
- [x] Future runs will compare against this baseline
- [x] Performance regressions will be automatically detected

## Conclusion

✅ **Initial baseline successfully established.** Future benchmark runs will compare against these values.
