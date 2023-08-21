using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppForAnagrams.Analyzers
{
    public class Pangram
    {
        public static bool IsPangram(string pangramName)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            foreach(char c in alphabet)
            {
                if (!pangramName.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
