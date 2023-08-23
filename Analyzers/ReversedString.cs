using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppForAnagrams.Analyzers
{
    public class ReversedString
    {
        public static string Reverse(string input)
        {
            string reversedString = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString += input[i];
            }
            return reversedString;
        }
    }
}
