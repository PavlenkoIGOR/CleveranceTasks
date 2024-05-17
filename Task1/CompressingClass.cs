using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal static class CompressingClass
    {
        internal static string CompressedString(this string str)
        {
            char previousChar = str[0];
            string compressedStr = "";

            int countChar = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (previousChar == str[i]) //if the chars are repeats...
                {
                    countChar++;
                }
                else //if not
                {
                    compressedStr += previousChar;

                    if (countChar > 1)
                        compressedStr += countChar;

                    previousChar = str[i];
                    countChar = 1;
                }
            }

            //for last type of the char
            compressedStr += previousChar;
            if (countChar > 1)
            {
                compressedStr += countChar;
            }
            return compressedStr;
        }
    }
}
