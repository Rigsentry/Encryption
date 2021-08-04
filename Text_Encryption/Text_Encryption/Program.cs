using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Text_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            var s1 = "if man was meant to stay on the ground god would have given us roots";
            var s2 = "haveaniceday";
            var s3 = "feedthedog";
            var s4 = "chillout";


            Console.WriteLine(encryption(s1));
            Console.WriteLine(encryption(s2));
            Console.WriteLine(encryption(s3));
            Console.WriteLine(encryption(s4));

            static string encryption(string s)
            {
                //remove white spaces
                s = s.Replace(" ", string.Empty);

                //l is the length of the string
                var l = s.Length;

                //square Root Value of the Length
                var squareRoot = Math.Sqrt(l);

                //lower value of the decimal number
                var rows = (int) Math.Floor(squareRoot);

                //highest value of the decimal number
                var columns = (int) Math.Ceiling(squareRoot);

                //Ensure that rows x columns ≥ L
                if (rows * columns < l)
                {
                    rows++;
                }
                
                var tempString = "";
                var textList = new List<string>();

                //create list of string every nth = columns interval
                for (var i = 0; i < l; i += columns)
                {
                    if (i + columns <= l)
                    {
                        tempString = s.Substring(i, columns);
                        textList.Add(tempString);
                    }
                    //else if i is greater than the length just create a substring of the remaining characters and add it to the list
                    else
                    {
                        var remain = l - i;
                        tempString = s.Substring(i, remain);
                        textList.Add(tempString);
                    }
                    
                }                              

                var encryptedText = "";

                //create a string using the first letter of each string in the list separated by a space
                for (var i = 0; i < columns; i++)
                {
                    for (var j = 0; j < rows; j++)
                    {
                        //if the string length in the list is equal to the columns number just add the character to the new string
                        if (textList[j].Length == columns)
                        {
                            encryptedText = encryptedText + textList[j][i];
                        }
                        //if the string length in the list is less than the columns add characters to the new string as long as the charater index is inside the string length
                        else if (i < textList[j].Length)
                        {
                            encryptedText = encryptedText + textList[j][i];
                        }                        
                    }
                    encryptedText = encryptedText + " ";
                }
                return encryptedText;
            }
        }
    }
}
