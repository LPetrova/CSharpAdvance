using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSubstringOccurrences
{
    static void Main()
    {
        Console.WriteLine("Enter some text: ");
        string text = Console.ReadLine().ToLower();
        Console.WriteLine("Enter a string to search for: ");
        string searchText = Console.ReadLine().ToLower();
        int count = 0;

        for (int i = 0; i < text.Length - searchText.Length + 1; i++)
        {
            if ((text.Substring(i, searchText.Length) == searchText))
            {
                count++;
            }
        }
        Console.WriteLine("{0} is found  {1} times ", searchText, count);



    }
}

