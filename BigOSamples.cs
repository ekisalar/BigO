using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BigO;

public class BigOSamples
{
    public int Sample_1(IEnumerable<string> inputList)
    {
        var a = 10; // O(1)
        a = 50 + 3; // O(1)
        foreach (var input in inputList) // O(n)
        {
            AnotherFunction(); // O(n)
            var stranger = true; // O(n)
            a++; //O(n)
        }

        return a; //O(1)
        //BIG O(3+4n)
    }


    public void Sample_2(IEnumerable<int> input)
    {
        var a = 5; // O(1)
        var b = 10; // O(1)
        var c = 50; // O(1)
        foreach (var i in input) // O(n)
        {
            var x = i + 1; // O(n)
            var y = i + 2; // O(n)
            var z = i + 3; // O(n)
        }

        foreach (var j in input) // O(n)
        {
            var p = j * 2; // O(n)
            var q = j * 2; // O(n)
        }

        var whoAmI = "I don't know"; // O(1)
        // Big O(4+7n)  
    }

    public void Sample_3(IEnumerable<int> list1, IEnumerable<int> list2)
    {
        foreach (var i in list1) //O(a)
        {
            Console.WriteLine(i);
        }

        foreach (var i in list2) //O(b)
        {
            Console.WriteLine(i);
        }
        // Big O(a + b)
    }

    public void Sample_4(IEnumerable<int> list1, IEnumerable<int> list2)
    {
        foreach (var i in list1) //O(a)
        {
            Console.WriteLine(i);
            foreach (var j in list2) //O(b)
            {
                Console.WriteLine(j);
            }
        }
        // Big O(a*b)
    }

    public void Sample_5(IEnumerable<int> list)
    {
        Console.WriteLine("These are the numbers"); // O(1)
        foreach (var i in list) // O(n)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("These are the pair sums: "); // O(1)
        foreach (var i in list) //O(n)
        {
            foreach (var j in list) //O(n)
            {
                Console.WriteLine(i + j);
            }
        }
    } // O(2 + n + n^2) => most dominant term is n^2 => O(n^2)

    private static void AnotherFunction()
    {
    }
}