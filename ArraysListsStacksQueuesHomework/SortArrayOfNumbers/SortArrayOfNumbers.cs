using System;
using System.Linq;

class SortArrayOfNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] numbers = input.Split().Select(int.Parse).ToArray();

        Array.Sort(numbers);

        Console.WriteLine();
        Console.WriteLine("Sorted numbers are: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            
            Console.Write(numbers[i] + " ");
        }
    }
}

