using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder inputSb;

        if (input.Length  > 20)
        {
            inputSb = new StringBuilder(input.Substring(0, 20));
        }
        else
        {
            inputSb = new StringBuilder(input);
            while (inputSb.Length < 20)
            {
                 inputSb.Append('*');
            }
           
        }
        Console.WriteLine(inputSb.ToString());        
    }

}
    

