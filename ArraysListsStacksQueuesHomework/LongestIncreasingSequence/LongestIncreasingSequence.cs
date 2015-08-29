using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestIncreasingSequence
{
    static void Main()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        List<int> items = new List<int>();
        List<int> longest = new List<int>();

        for (int i = 0, j=1; i < numbers.Length; i++, j++)
        {
            items.Add(numbers[i]);

            if ((j < numbers.Length) && (numbers[i] <= numbers[j]))
            {
                continue;
            }
            else
            {
                if (items.Count > longest.Count)
                {
                    longest.Clear();
                    longest.AddRange(items);
                    Console.WriteLine(string.Join(" ", items));
                    items.Clear();
                }
                else
                {
                    Console.WriteLine(string.Join(" ", items));
                    items.Clear();
                }
            }
        }
        Console.WriteLine("Longest: " + string.Join(" ", longest));

    }
}

