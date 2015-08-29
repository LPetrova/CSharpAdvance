using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReplaceTag
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"<a\s+href=([^>]+)>([^<]+)</a>";
        Regex regex = new Regex(pattern);
        string replacement = "[URL href=$1]$2[/URL]";
        string result = Regex.Replace(input, pattern, replacement);
        Console.WriteLine(result);

        //Console.WriteLine("Enter HTML document");
        //string textHTML = Console.ReadLine();
        //string output = string.Empty;
        //int counter = 0;
        //while (textHTML.IndexOf("<a href=\"", counter) > 0)
        //{
        //    output = textHTML.Replace("<a href=\"", "[URL=");
        //    counter++;
        //}
        //counter = 0;
        //while (output.IndexOf("\">", counter) > 0)
        //{
        //    output = output.Replace("\">", "]");
        //    counter++;
        //}
        //counter = 0;
        //while (output.IndexOf("</a>", counter) > 0)
        //{
        //    output = output.Replace("</a>", "[/URL]");
        //    counter++;
        //}
        //Console.WriteLine(output);
    }
}

