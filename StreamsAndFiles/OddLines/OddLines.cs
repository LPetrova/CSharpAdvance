using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("..//..//Text//OddLine.txt");
            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.Write(ex.Message);
        }
    }
}

