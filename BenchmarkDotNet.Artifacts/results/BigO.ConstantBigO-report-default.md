
BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT AVX2


| Method  |     Mean |   Error |   StdDev |
|---------|---------:|--------:|---------:|
| RunOne  | 147.5 μs | 2.91 μs |  3.79 μs |
| RunFive | 156.4 μs | 3.99 μs | 11.77 μs |
| RunTen  | 156.4 μs | 2.94 μs |  3.62 μs |
