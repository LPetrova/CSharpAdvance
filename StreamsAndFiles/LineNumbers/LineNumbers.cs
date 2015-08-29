using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LineNumbers
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("..\\..\\textInput.txt");
            StreamWriter writer = new StreamWriter("..\\..\\textInput.out");
            using (writer)
            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("{0:D2}.{1}", lineNumber, line);
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }

        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
           
        }
    }
}

