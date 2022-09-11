
BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT AVX2


     Method |        Mean |     Error |    StdDev |
----------- |------------:|----------:|----------:|
     RunOne |    323.2 ns |   1.67 ns |   1.56 ns |
    RunFive |  1,372.7 ns |  15.14 ns |  12.64 ns |
     RunTen |  2,582.7 ns |  12.84 ns |  12.01 ns |
  RunTwenty |  5,213.5 ns |  98.81 ns | 113.79 ns |
 RunHundred | 25,073.1 ns | 144.32 ns | 127.94 ns |
