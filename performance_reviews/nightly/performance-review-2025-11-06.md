# Performance Review Results - Initial Baseline

**Date**: 2025-11-06 23:58:41 UTC
**Baseline**: Initial Run
**Commit**: 

## Summary

This is the **initial benchmark run**. No baseline exists for comparison.

- **Total Benchmarks**: 23
- **Status**: ✅ INITIAL BASELINE ESTABLISHED

## Benchmarks Recorded

The following benchmarks will serve as the baseline for future comparisons:


### CPU Benchmarks

- **CreateSuccessResult_String**: 8.400 ns (24 B)
- **CreateSuccessResult_Int**: 19.009 ns (24 B)
- **CreateSuccessResult_Unit**: 15.868 ns (24 B)
- **CreateFailureResult_String**: 9.046 ns (24 B)
- **CreateFailureResult_Int**: 8.987 ns (24 B)
- **CreateFailureResult_Unit**: 8.917 ns (24 B)
- **GetValue_Success**: 9.637 ns (24 B)
- **GetError_Failure**: 8.162 ns (24 B)
- **CheckIsSuccess_OnSuccessResult**: 8.612 ns (24 B)
- **CheckIsFailure_OnFailureResult**: 6.685 ns (24 B)
- **CompleteSuccessWorkflow**: 13.593 ns (24 B)
- **CompleteFailureWorkflow**: 8.780 ns (24 B)
- **NestedResults**: 13.950 ns (48 B)

### Memory Benchmarks

- **CreateAndStoreResultsInArray**: 52711.860 ns (84,024 B, Gen0/1/2: 0.0/5.0/1.2)
- **CreateAndStoreResultsInList**: 33990.350 ns (64,056 B, Gen0/1/2: 0.0/3.8/0.7)
- **ReuseSuccessResult**: 8115.640 ns (24 B, Gen0/1/2: 0.0/0.0/0.0)
- **ReuseErrorInstance**: 14003.360 ns (24,024 B, Gen0/1/2: 0.0/1.4/0.1)
- **CreateNewErrorInstances**: 55585.900 ns (88,000 B, Gen0/1/2: 0.0/5.2/1.7)
- **CreateNewValueInstances**: 50380.120 ns (64,000 B, Gen0/1/2: 0.0/3.8/0.7)
- **ChainedResultProcessing**: 193.940 ns (376 B, Gen0/1/2: 0.0/0.0/0.0)
- **ResultWithLargeValue**: 344.980 ns (10,048 B, Gen0/1/2: 0.0/0.6/0.0)
- **FilterResults**: 46425.940 ns (86,024 B, Gen0/1/2: 0.0/5.1/1.0)
- **ResultsInDictionary**: 98057.800 ns (198,136 B, Gen0/1/2: 0.0/11.7/5.7)

## Next Steps

- [x] Initial baseline established
- [x] Future runs will compare against this baseline
- [x] Performance regressions will be automatically detected

## Conclusion

✅ **Initial baseline successfully established.** Future benchmark runs will compare against these values.
