using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Eneter array length: ");
        int input = int.Parse(Console.ReadLine());
        int[] numbers = new int[input];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(GetFirstLargerThanNeighbours(numbers));
    }

    static int GetFirstLargerThanNeighbours(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return i;
                }
            }
            else if (i == numbers.Length && numbers[i] > numbers[i-1])
            {
                return i;
            }
            else 
            {
                if ((numbers[i] > numbers[i - 1]) && (numbers[i] > numbers[i + 1]))
                {                 
                    return i;		 
	            }
            }
        }
        return -1;
    }
}

