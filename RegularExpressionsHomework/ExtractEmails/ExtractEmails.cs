﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        string emailPattern = @"\b([A-Za-z0-9]+?)[\w\-\.]*?[A-Za-z0-9]+?@[A-Za-z0-9]+?([\w\-\.]+)\2*?\.[\w]{2,}\b";
        Regex regex = new Regex(emailPattern);
        MatchCollection matches = regex.Matches(input);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

    }
}

