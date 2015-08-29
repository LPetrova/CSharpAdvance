using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Palindromes
{
    static void Main(string[] args)
    {
        HashSet<string> palindromes = new HashSet<string>();
        string text = Console.ReadLine();
        string[] inputText = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in inputText)
        {
            StringBuilder wordSB = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                char currentChar = word[i];
                wordSB.Append(currentChar);
            }

            if (wordSB.ToString() == word)
            {
                palindromes.Add(word);
            }
        }
        SortedSet<string> sortedPalindromes = new SortedSet<string>(palindromes);
        Console.WriteLine(string.Join(", ", sortedPalindromes));
    }
}


