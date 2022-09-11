BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT AVX2


          Method |      Mean |     Error |    StdDev |    Median |
---------------- |----------:|----------:|----------:|----------:|
 RunThreeElement |  1.266 ms | 0.0641 ms | 0.1829 ms |  1.344 ms |
   RunSixElement |  5.103 ms | 0.1525 ms | 0.4496 ms |  5.364 ms |
  RunNineElement | 14.041 ms | 0.2804 ms | 0.7387 ms | 14.344 ms |
