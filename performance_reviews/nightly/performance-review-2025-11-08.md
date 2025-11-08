# Performance Review Results - Initial Baseline

**Date**: 2025-11-08 01:41:19 UTC
**Baseline**: Initial Run
**Commit**: 

## Summary

This is the **initial benchmark run**. No baseline exists for comparison.

- **Total Benchmarks**: 23
- **Status**: ✅ INITIAL BASELINE ESTABLISHED

## Benchmarks Recorded

The following benchmarks will serve as the baseline for future comparisons:


### CPU Benchmarks

- **CreateSuccessResult_String**: 6.666 ns (24 B)
- **CreateSuccessResult_Int**: 16.226 ns (24 B)
- **CreateSuccessResult_Unit**: 12.673 ns (24 B)
- **CreateFailureResult_String**: 8.071 ns (24 B)
- **CreateFailureResult_Int**: 8.862 ns (24 B)
- **CreateFailureResult_Unit**: 8.181 ns (24 B)
- **GetValue_Success**: 8.468 ns (24 B)
- **GetError_Failure**: 8.120 ns (24 B)
- **CheckIsSuccess_OnSuccessResult**: 8.431 ns (24 B)
- **CheckIsFailure_OnFailureResult**: 5.450 ns (24 B)
- **CompleteSuccessWorkflow**: 6.523 ns (24 B)
- **CompleteFailureWorkflow**: 7.599 ns (24 B)

### Memory Benchmarks

- **CreateAndStoreResultsInArray**: 49278.320 ns (84,024 B, Gen0/1: 5.0/1.2)
- **CreateAndStoreResultsInList**: 32575.850 ns (64,056 B, Gen0/1: 3.8/0.7)
- **ReuseSuccessResult**: 9323.300 ns (24 B, Gen0/1: 0.0/0.0)
- **ReuseErrorInstance**: 13841.520 ns (24,024 B, Gen0/1: 1.4/0.1)
- **CreateNewErrorInstances**: 53453.140 ns (88,000 B, Gen0/1: 5.2/1.6)
- **CreateNewValueInstances**: 53399.390 ns (64,000 B, Gen0/1: 3.8/0.6)
- **ChainedResultProcessing**: 209.860 ns (376 B, Gen0/1: 0.0/0.0)
- **NestedResults**: 13.470 ns (48 B, Gen0/1: 0.0/0.0)
- **ResultWithLargeValue**: 330.270 ns (10,048 B, Gen0/1: 0.6/0.0)
- **FilterResults**: 50287.680 ns (86,024 B, Gen0/1: 5.1/1.0)
- **ResultsInDictionary**: 93914.200 ns (198,136 B, Gen0/1: 11.5/5.3)

## Next Steps

- [x] Initial baseline established
- [x] Future runs will compare against this baseline
- [x] Performance regressions will be automatically detected

## Conclusion

✅ **Initial baseline successfully established.** Future benchmark runs will compare against these values.
