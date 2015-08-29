using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FillTheMatrixTopBotton
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int [n, n];
        int count = 1;

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++, count++)
            {
                matrix[j, i] = count;
            }
        }
        MatrixPrint(matrix);
    }

    static void MatrixPrint(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

}

