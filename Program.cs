using System;

namespace MaxList;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>()
            { 107, 92, 3, 46, 5096, 666, 85 };

        int maxNumber = numbers.Max();

        Console.WriteLine("The largest number in the list is: " + maxNumber);
    }
}

