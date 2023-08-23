using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsAppForAnagrams.Analyzers
{
    public class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            string newString = "";
            phrase = Regex.Replace(phrase.ToUpper(), @"[^a-zA-Z0-9\s-]", ""); // Keep hyphens

            string[] words = Regex.Split(phrase, @"[\s-]+"); // Split on spaces or hyphens

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    newString += word[0];
                }
            }

            return newString;
        }
    }
}
