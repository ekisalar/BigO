using BenchmarkDotNet.Attributes;

namespace BigO;

[MarkdownExporter]
public class QuadraticBigO
{
    private readonly FakeData _fakeData;

    public QuadraticBigO()
    {
        _fakeData = new FakeData();
    }

    private static List<string> Boxes1 => new() {"a", "b", "c",};
    private static List<string> Boxes2 => new() {"a", "b", "c", "d", "e", "f",};
    private static List<string> Boxes3 => new() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"};

    [Benchmark]
    public void RunThreeElement() => LogAllPairsOfArray(Boxes1);

    [Benchmark]
    public void RunSixElement() => LogAllPairsOfArray(Boxes2);

    [Benchmark]
    public void RunNineElement() => LogAllPairsOfArray(Boxes3);

    private static void LogAllPairsOfArray(List<string> itemList)
    {
        foreach (var item1 in itemList) // O(n)
        {
            foreach (var item2 in itemList) // O(n)
            {
                Console.WriteLine(item1 + " " + item2);
            }
        }
        // O(n^2)
    }
}