# Performance Review Results

**Date**: 2026-03-22 22:49:18 UTC
**Baseline**: 2025-12-07T22:43:23.356205
**Commit**: c74c5224096e471502d21ace612c9d5c1553709e

## Summary

- **Total Benchmarks**: 23
- **Regressions**: 2
- **Improvements**: 0
- **Status**: ⚠️ REGRESSIONS FOUND (MINOR)

## CPU Benchmarks

| Benchmark | Baseline | Current | Change | Status |
|-----------|----------|---------|--------|--------|
| CreateSuccessResult_String | 7.709 ns | 7.580 ns | -1.7% | ➡️  |
| CreateSuccessResult_Int | 7.511 ns | 7.551 ns | +0.5% | ➡️  |
| CreateSuccessResult_Unit | 7.928 ns | 8.151 ns | +2.8% | ➡️  |
| CreateFailureResult_String | 9.505 ns | 9.997 ns | +5.2% | ⚠️ MINOR |
| CreateFailureResult_Int | 9.216 ns | 9.158 ns | -0.6% | ➡️  |
| CreateFailureResult_Unit | 9.112 ns | 9.189 ns | +0.8% | ➡️  |
| GetValue_Success | 9.663 ns | 9.394 ns | -2.8% | ➡️  |
| GetError_Failure | 8.830 ns | 8.889 ns | +0.7% | ➡️  |
| CheckIsSuccess_OnSuccessResult | 8.915 ns | 9.057 ns | +1.6% | ➡️  |
| CheckIsFailure_OnFailureResult | 6.949 ns | 7.192 ns | +3.5% | ➡️  |
| CompleteSuccessWorkflow | 6.318 ns | 6.762 ns | +7.0% | ⚠️ MINOR |
| CompleteFailureWorkflow | 9.057 ns | 8.851 ns | -2.3% | ➡️  |

## Memory Benchmarks

| Benchmark | Baseline | Current | Alloc Change | Gen0/1 | Status |
|-----------|----------|---------|--------------|--------|--------|
| CreateAndStoreResultsInArray | 84,024 B | 84,024 B | 0.0% | 14.1/2.8 | ➡️  |
| CreateAndStoreResultsInList | 64,056 B | 64,056 B | 0.0% | 21.9/0.4 | ➡️  |
| ReuseSuccessResult | 24 B | 24 B | 0.0% | 0.0/0.0 | ➡️  |
| ReuseErrorInstance | 24,024 B | 24,024 B | 0.0% | 3.8/0.3 | ➡️  |
| CreateNewErrorInstances | 88,000 B | 88,000 B | 0.0% | 15.7/3.8 | ➡️  |
| CreateNewValueInstances | 64,000 B | 64,000 B | 0.0% | 10.2/1.3 | ➡️  |
| ChainedResultProcessing | 376 B | 376 B | 0.0% | 0.1/0.0 | ➡️  |
| NestedResults | 48 B | 48 B | 0.0% | 0.0/0.0 | ➡️  |
| ResultWithLargeValue | 10,048 B | 10,048 B | 0.0% | 3.8/0.0 | ➡️  |
| FilterResults | 86,024 B | 86,024 B | 0.0% | 15.0/2.8 | ➡️  |
| ResultsInDictionary | 198,136 B | 198,136 B | 0.0% | 30.5/10.2 | ➡️  |

## Regressions

### CreateFailureResult_String - MINOR

- **Baseline**: 9.505 ns (24 B allocated)
- **Current**: 9.997 ns (24 B allocated)
- **Change**: +5.2%
- **Recommendation**: Monitor

### CompleteSuccessWorkflow - MINOR

- **Baseline**: 6.318 ns (24 B allocated)
- **Current**: 6.762 ns (24 B allocated)
- **Change**: +7.0%
- **Recommendation**: Monitor


## Action Items

- [ ] Review regression details above
- [ ] Investigate root cause of performance degradation
- [ ] Fix regression or document justification

## Conclusion

⚠️ **2 regression(s) detected with MINOR severity.** Please review and address before baseline is updated.
