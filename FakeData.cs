using Bogus;

namespace BigO;

public class FakeData
{
    private readonly Faker _faker = new();

    public IEnumerable<string> OneElementArray     => _faker.Random.WordsArray(1);
    public IEnumerable<string> FiveElementArray    => _faker.Random.WordsArray(5);
    public IEnumerable<string> TenElementArray     => _faker.Random.WordsArray(10);
    public IEnumerable<string> TwentyElementArray  => _faker.Random.WordsArray(500000);
    public IEnumerable<string> HundredElementArray => _faker.Random.WordsArray(1000000);
}