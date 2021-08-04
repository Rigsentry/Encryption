using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = encryption("haveaniceday");
            //var a = encryption("feedthedog");
            var a = encryption("chillout");
            Console.WriteLine(a);
        }

        public static string encryption(string s)
        {
            double sqr = Math.Sqrt(s.Length);
            int rows = (int)Math.Truncate(sqr);
            int columns = rows == sqr ? rows : rows + 1;
            if(rows * columns < s.Length)
            {
                rows++;
            }
            char[,] encMatrix = new char[rows, columns];
            StringBuilder output = new StringBuilder();
            
            int row = 0;
            int column = 0;
            foreach (var item in s)
            {
                encMatrix[row, column] = item;
                if (column == columns - 1)
                {
                    column = 0;
                    row++;
                }
                else
                    column++;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if((int)encMatrix[j, i] != 0)
                        output.Append(encMatrix[j, i]);
                }
                output.Append(' ');
            }
            return output.ToString();
        }
    }
}
