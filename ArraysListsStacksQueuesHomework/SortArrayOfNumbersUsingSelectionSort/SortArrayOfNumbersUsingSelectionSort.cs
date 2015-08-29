using System;

class SortArrayOfNumbersUsingSelectionSort
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0; i < input.Length - 1; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] > input[j])
                {
                    int items = input[i];
                    input[i] = input[j];
                    input[j] = items;
                }
            }
        }

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(input[i] + " ");
        }
    }

}

