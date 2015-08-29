using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextFilter
{
    static void Main()
    {
        string[] filter = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        StringBuilder textBuilder = new StringBuilder(text);

        foreach (string word in filter)
        {
            string mask = new string('*', word.Length);
            textBuilder.Replace(word, mask);
        }
        Console.WriteLine(textBuilder.ToString());
       
        
    }
}

