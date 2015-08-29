using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LastDigitOfNumber
{

    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Output: {0}",LastDigitAsWord(number));
    }

   private static string LastDigitAsWord (int num)
    {
        string[] digitAsWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int digit = num % 10;

        return digitAsWord[num];
    }
}

