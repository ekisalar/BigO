using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Bogus;

namespace BigO;

[MarkdownExporter]
public class LinearBigO
{
    private readonly FakeData _fakeData;

    public LinearBigO()
    {
        _fakeData = new FakeData();
    }

    [Benchmark]
    public void RunOne() => FindWord("engin", _fakeData.OneElementArray);

    [Benchmark]
    public void RunFive() => FindWord("engin", _fakeData.FiveElementArray);

    [Benchmark]
    public void RunTen() => FindWord("engin", _fakeData.TenElementArray);

    [Benchmark]
    public void RunTwenty() => FindWord("engin", _fakeData.TwentyElementArray);

    [Benchmark]
    public void RunHundred() => FindWord("engin", _fakeData.HundredElementArray);


    private static void FindWord(string wordToFind, IEnumerable<string> words)
    {
        foreach (var word in words)
        {
            if (word == wordToFind)
            {
                Console.Write("Word found");
                break; // !!! Putting break into here make code more efficient. 
                // But BigO remains O(n) because this is the WORSTCASE
            }
        }
    }
}