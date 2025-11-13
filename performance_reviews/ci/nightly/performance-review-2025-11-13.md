# Performance Review Results - Initial Baseline

**Date**: 2025-11-13 05:39:24 UTC
**Baseline**: Initial Run
**Commit**: 6b36e567178926362509080d7bd774b1dba343f4

## Summary

This is the **initial benchmark run**. No baseline exists for comparison.

- **Total Benchmarks**: 23
- **Status**: ✅ INITIAL BASELINE ESTABLISHED

## Benchmarks Recorded

The following benchmarks will serve as the baseline for future comparisons:


### CPU Benchmarks

- **CreateSuccessResult_String**: 14.829 ns (24 B)
- **CreateSuccessResult_Int**: 7.658 ns (24 B)
- **CreateSuccessResult_Unit**: 7.967 ns (24 B)
- **CreateFailureResult_String**: 9.559 ns (24 B)
- **CreateFailureResult_Int**: 9.552 ns (24 B)
- **CreateFailureResult_Unit**: 9.191 ns (24 B)
- **GetValue_Success**: 9.446 ns (24 B)
- **GetError_Failure**: 8.880 ns (24 B)
- **CheckIsSuccess_OnSuccessResult**: 9.191 ns (24 B)
- **CheckIsFailure_OnFailureResult**: 7.007 ns (24 B)
- **CompleteSuccessWorkflow**: 7.162 ns (24 B)
- **CompleteFailureWorkflow**: 8.850 ns (24 B)

### Memory Benchmarks

- **CreateAndStoreResultsInArray**: 52856.840 ns (84,024 B, Gen0/1: 14.1/2.7)
- **CreateAndStoreResultsInList**: 37389.890 ns (64,056 B, Gen0/1: 24.0/0.1)
- **ReuseSuccessResult**: 6569.730 ns (24 B, Gen0/1: 0.0/0.0)
- **ReuseErrorInstance**: 14019.010 ns (24,024 B, Gen0/1: 3.9/0.3)
- **CreateNewErrorInstances**: 56590.460 ns (88,000 B, Gen0/1: 15.7/3.9)
- **CreateNewValueInstances**: 48036.720 ns (64,000 B, Gen0/1: 10.4/1.5)
- **ChainedResultProcessing**: 201.640 ns (376 B, Gen0/1: 0.1/0.0)
- **NestedResults**: 14.480 ns (48 B, Gen0/1: 0.0/0.0)
- **ResultWithLargeValue**: 718.110 ns (10,048 B, Gen0/1: 3.8/0.0)
- **FilterResults**: 48198.690 ns (86,024 B, Gen0/1: 15.2/2.9)
- **ResultsInDictionary**: 99677.680 ns (198,136 B, Gen0/1: 30.8/7.8)

## Next Steps

- [x] Initial baseline established
- [x] Future runs will compare against this baseline
- [x] Performance regressions will be automatically detected

## Conclusion

✅ **Initial baseline successfully established.** Future benchmark runs will compare against these values.
