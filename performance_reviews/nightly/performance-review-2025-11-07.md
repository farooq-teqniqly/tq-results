# Performance Review Results - Initial Baseline

**Date**: 2025-11-07 01:16:16 UTC
**Baseline**: Initial Run
**Commit**: 

## Summary

This is the **initial benchmark run**. No baseline exists for comparison.

- **Total Benchmarks**: 23
- **Status**: ✅ INITIAL BASELINE ESTABLISHED

## Benchmarks Recorded

The following benchmarks will serve as the baseline for future comparisons:


### CPU Benchmarks

- **CreateSuccessResult_String**: 7.354 ns (24 B)
- **CreateSuccessResult_Int**: 7.237 ns (24 B)
- **CreateSuccessResult_Unit**: 17.208 ns (24 B)
- **CreateFailureResult_String**: 8.954 ns (24 B)
- **CreateFailureResult_Int**: 8.824 ns (24 B)
- **CreateFailureResult_Unit**: 9.120 ns (24 B)
- **GetValue_Success**: 9.014 ns (24 B)
- **GetError_Failure**: 7.971 ns (24 B)
- **CheckIsSuccess_OnSuccessResult**: 8.483 ns (24 B)
- **CheckIsFailure_OnFailureResult**: 6.605 ns (24 B)
- **CompleteSuccessWorkflow**: 13.194 ns (24 B)
- **CompleteFailureWorkflow**: 8.140 ns (24 B)

### Memory Benchmarks

- **CreateAndStoreResultsInArray**: 52414.510 ns (84,024 B, Gen0/1: 5.0/1.2)
- **CreateAndStoreResultsInList**: 32296.340 ns (64,056 B, Gen0/1: 3.8/0.7)
- **ReuseSuccessResult**: 8110.330 ns (24 B, Gen0/1: 0.0/0.0)
- **ReuseErrorInstance**: 13830.260 ns (24,024 B, Gen0/1: 1.4/0.1)
- **CreateNewErrorInstances**: 52449.380 ns (88,000 B, Gen0/1: 5.2/1.7)
- **CreateNewValueInstances**: 48006.480 ns (64,000 B, Gen0/1: 3.8/0.7)
- **ChainedResultProcessing**: 178.610 ns (376 B, Gen0/1: 0.0/0.0)
- **NestedResults**: 13.520 ns (48 B, Gen0/1: 0.0/0.0)
- **ResultWithLargeValue**: 309.180 ns (10,048 B, Gen0/1: 0.6/0.0)
- **FilterResults**: 43375.060 ns (86,024 B, Gen0/1: 5.1/1.0)
- **ResultsInDictionary**: 92732.400 ns (198,136 B, Gen0/1: 11.7/5.7)

## Next Steps

- [x] Initial baseline established
- [x] Future runs will compare against this baseline
- [x] Performance regressions will be automatically detected

## Conclusion

✅ **Initial baseline successfully established.** Future benchmark runs will compare against these values.
