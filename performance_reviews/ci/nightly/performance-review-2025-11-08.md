# Performance Review Results - Initial Baseline

**Date**: 2025-11-08 21:44:25 UTC
**Baseline**: Initial Run
**Commit**: f12987a3652d512ce35b3fbdebaa2ff1b4ec91b6

## Summary

This is the **initial benchmark run**. No baseline exists for comparison.

- **Total Benchmarks**: 23
- **Status**: ✅ INITIAL BASELINE ESTABLISHED

## Benchmarks Recorded

The following benchmarks will serve as the baseline for future comparisons:


### CPU Benchmarks

- **CreateSuccessResult_String**: 7.480 ns (24 B)
- **CreateSuccessResult_Int**: 7.442 ns (24 B)
- **CreateSuccessResult_Unit**: 7.847 ns (24 B)
- **CreateFailureResult_String**: 9.418 ns (24 B)
- **CreateFailureResult_Int**: 9.047 ns (24 B)
- **CreateFailureResult_Unit**: 9.045 ns (24 B)
- **GetValue_Success**: 8.979 ns (24 B)
- **GetError_Failure**: 8.772 ns (24 B)
- **CheckIsSuccess_OnSuccessResult**: 8.816 ns (24 B)
- **CheckIsFailure_OnFailureResult**: 6.901 ns (24 B)
- **CompleteSuccessWorkflow**: 7.006 ns (24 B)
- **CompleteFailureWorkflow**: 8.477 ns (24 B)

### Memory Benchmarks

- **CreateAndStoreResultsInArray**: 52143.810 ns (84,024 B, Gen0/1: 14.4/2.9)
- **CreateAndStoreResultsInList**: 35515.440 ns (64,056 B, Gen0/1: 20.7/0.2)
- **ReuseSuccessResult**: 6559.560 ns (24 B, Gen0/1: 0.0/0.0)
- **ReuseErrorInstance**: 14737.000 ns (24,024 B, Gen0/1: 9.2/0.0)
- **CreateNewErrorInstances**: 55423.150 ns (88,000 B, Gen0/1: 15.6/3.5)
- **CreateNewValueInstances**: 47325.480 ns (64,000 B, Gen0/1: 10.0/1.5)
- **ChainedResultProcessing**: 198.940 ns (376 B, Gen0/1: 0.1/0.0)
- **NestedResults**: 14.120 ns (48 B, Gen0/1: 0.0/0.0)
- **ResultWithLargeValue**: 690.190 ns (10,048 B, Gen0/1: 3.8/0.0)
- **FilterResults**: 48246.960 ns (86,024 B, Gen0/1: 15.1/2.9)
- **ResultsInDictionary**: 98298.110 ns (198,136 B, Gen0/1: 30.8/7.5)

## Next Steps

- [x] Initial baseline established
- [x] Future runs will compare against this baseline
- [x] Performance regressions will be automatically detected

## Conclusion

✅ **Initial baseline successfully established.** Future benchmark runs will compare against these values.
