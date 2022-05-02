# sort-benchmark
// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1645 (21H2)
AMD Ryzen 7 4700U with Radeon Graphics, 1 CPU, 8 logical and 8 physical cores
.NET SDK=5.0.103
  [Host]     : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT


|      Method |      Mean |     Error |    StdDev |
|------------ |----------:|----------:|----------:|
|   ShellSort |  7.809 us | 0.0306 us | 0.0271 us |
|       Radix | 67.670 us | 0.2329 us | 0.2178 us |
| BuiltInSort |  3.729 us | 0.0149 us | 0.0132 us |

// * Warnings *
Environment
  Summary -> Benchmark was executed with attached debugger

// * Hints *
Outliers
  SortsBenchmark.ShellSort: Default   -> 1 outlier  was  removed (7.90 us)
  SortsBenchmark.Radix: Default       -> 1 outlier  was  detected (67.19 us)
  SortsBenchmark.BuiltInSort: Default -> 1 outlier  was  removed (3.78 us)

// * Legends *
  Mean   : Arithmetic mean of all measurements
  Error  : Half of 99.9% confidence interval
  StdDev : Standard deviation of all measurements
  1 us   : 1 Microsecond (0.000001 sec)