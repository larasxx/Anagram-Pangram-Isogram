using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppForAnagrams.Analyzers
{
    public class Isogram
    {
        public static bool IsIsogram(string word)
        {
            word = word.ToLower();
            for(int i = 0; i < word.Length; i++)
            {
                for(int j = i + 1; j <word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }
    }
}
