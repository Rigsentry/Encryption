using System;
using System.Linq;

namespace CodeChallengeEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encryption("feed the dog"));
            Console.WriteLine(Encryption("chillout"));
        }

        public static string Encryption(string s)
        {
            Console.WriteLine("Input: " + s);
            string output = String.Concat(s.Where(c => !Char.IsWhiteSpace(c))); //removing white space
            int lengthOfString = output.Length;
            int row = (int)Math.Floor(Math.Sqrt(lengthOfString));
            int col = (int)Math.Ceiling(Math.Sqrt(lengthOfString));
            while ( row * col <= lengthOfString)
            {
                row++;
            }
            string[,] grid = new string[row, col];
            int i, j;
            int stringcounter = 0;
            for(i = 0;i< row; i++)
            {
                for(j=0; j< col; j++)
                {
                    if (stringcounter < lengthOfString)
                    {
                        grid[i, j] = output[stringcounter++].ToString();
                    }
                }
            }

            output = "";
            for (i = 0; i < col; i++)
            {
                for (j = 0; j < row; j++)
                {
                    if(grid[j, i] != " " || grid[j, i] != null)
                    {
                        output = output + grid[j, i];
                    }
                }
                output = output + " ";
            }
            return output;
        }
    }
}
