using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SeriesOfLetters
{
    static void Main()
    {
        string text = Console.ReadLine();
        Regex regex = new Regex(@"([a-zA-Z])\1{0,}");

        MatchCollection matches = regex.Matches(text);

        string result = null;
        for (int i = 0; i < matches.Count; i++)
        {
            result += matches[i].ToString().Substring(0, 1);
        }

        Console.WriteLine(result);


    }
}

