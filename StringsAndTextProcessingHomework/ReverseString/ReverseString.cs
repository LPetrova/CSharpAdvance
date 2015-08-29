using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main()
    {
        string text = Console.ReadLine();
        string reversed = Reverse(text);
        Console.WriteLine(reversed);
    }

    static string Reverse (string text)
    {
        StringBuilder result = new StringBuilder(text.Length);

        for (int i = text.Length - 1; i >= 0; i--)
        {
           result.Append(text[i]);
        }
        return result.ToString();
    }

}

