using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text = "if man was meant to stay on the ground god would have given us roots";
            //string text = "haveaniceday";
            //string text = "feedthedog";
            //string text = "chillout";

            Console.WriteLine(Encryption(text));
            Console.ReadLine();
        }
        public static string Encryption(string s)
        {
            s= s.Replace(" ", string.Empty);
            int floorValue = (int) Math.Floor(Math.Sqrt(s.Length));
            int ceilValue =  (int) Math.Ceiling(Math.Sqrt(s.Length));

            string encryptedText = "";
            for (int i = 0; i <= floorValue; i++)
            {
                for (int j = i; j< s.Length; j+= ceilValue)
                {
                    encryptedText += s[j];
                }
                encryptedText += " ";
            }
            return encryptedText;
        }
    }
}
