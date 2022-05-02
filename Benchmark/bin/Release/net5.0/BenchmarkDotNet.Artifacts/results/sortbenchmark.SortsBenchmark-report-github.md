``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1645 (21H2)
AMD Ryzen 7 4700U with Radeon Graphics, 1 CPU, 8 logical and 8 physical cores
.NET SDK=5.0.103
  [Host]     : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT


```
|      Method |      Mean |     Error |    StdDev |
|------------ |----------:|----------:|----------:|
|   ShellSort |  7.809 μs | 0.0306 μs | 0.0271 μs |
|       Radix | 67.670 μs | 0.2329 μs | 0.2178 μs |
| BuiltInSort |  3.729 μs | 0.0149 μs | 0.0132 μs |
