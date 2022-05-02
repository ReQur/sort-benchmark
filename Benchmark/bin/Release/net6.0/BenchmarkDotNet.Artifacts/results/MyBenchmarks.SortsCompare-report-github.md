``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1526 (21H1/May2021Update)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|        Method |       Mean |      Error |     StdDev |     Median |
|-------------- |-----------:|-----------:|-----------:|-----------:|
| SelectionSort | 658.571 μs | 31.1579 μs | 91.8696 μs | 636.666 μs |
|    BubbleSort | 665.016 μs | 33.5596 μs | 98.9511 μs | 653.481 μs |
|   BuiltInSort |   7.644 μs |  0.2550 μs |  0.6537 μs |   7.970 μs |
