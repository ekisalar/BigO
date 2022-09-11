using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Bogus;

namespace BigO;

[MarkdownExporter]
public class ConstantBigO
{
    private FakeData _fakeData;


    public ConstantBigO()
    {
        _fakeData = new FakeData();
        Stopwatch stopwatch = new();
    }

    [GlobalSetup]
    public void GlobalSetup()
    {
        _fakeData = new FakeData();
    }

    [Benchmark]
    public void RunOne() => FindWord(new List<string>() {"engin"});

    [Benchmark]
    public void RunFive() => FindWord(new List<string>() {"engin", "ahmet", "mehmet", "cemil"});

    [Benchmark]
    public void RunTen() => FindWord(new List<string>() {"engin", "ahmet", "mehmet", "cemil", "temel", "yılmaz", "poyraz", "zeki", "tuna", "canan"});

    // [Benchmark]
    // public void RunTwenty() => FindWord(_fakeData.TwentyElementArray);
    //
    // [Benchmark]
    // public void RunHundred() => FindWord(_fakeData.HundredElementArray);

    public void BenchMark()
    {
        var elapsedTimes = new List<long>();
        var stopWatch    = new Stopwatch();
        stopWatch.Start();
        stopWatch.Restart();
        FindWord(_fakeData.OneElementArray);
        elapsedTimes.Add(stopWatch.ElapsedMilliseconds);
        stopWatch.Restart();
        FindWord(_fakeData.FiveElementArray);
        elapsedTimes.Add(stopWatch.ElapsedMilliseconds);
        stopWatch.Restart();
        FindWord(_fakeData.TenElementArray);
        elapsedTimes.Add(stopWatch.ElapsedMilliseconds);
        stopWatch.Restart();
        FindWord(_fakeData.TwentyElementArray);
        elapsedTimes.Add(stopWatch.ElapsedMilliseconds);
        stopWatch.Restart();
        FindWord(_fakeData.HundredElementArray);
        elapsedTimes.Add(stopWatch.ElapsedMilliseconds);
        stopWatch.Restart();
        elapsedTimes.ForEach(Console.WriteLine);
    }


    private static void FindWord(IEnumerable<string> words)
    {
        Console.WriteLine(words.First());
    }
}