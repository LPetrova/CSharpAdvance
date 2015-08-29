using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class SentenceExtractor
{
    static void Main()
    {
        string keyword = Console.ReadLine().Trim();
        keyword = @"\b" + keyword + @"\b";
        string text = Console.ReadLine();
       
        string sentencePattern = @"[A-Z][A-Za-z\s\-\,\:\'\u2019\u2013]*[\.\?\!]";
        Regex sentenceRegex = new Regex(sentencePattern);
        MatchCollection matches = sentenceRegex.Matches(text);
        foreach (Match match in matches)
        {
            string sentence = match.Value;
            if (Regex.IsMatch(sentence, keyword))
                Console.WriteLine(sentence);
        }

    }
}

