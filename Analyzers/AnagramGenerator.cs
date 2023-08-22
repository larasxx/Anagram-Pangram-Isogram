using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppForAnagrams.Analyzers
{
    public class AnagramGenerator
    {
        public static string CreateAnagram(string inputWord)
        {
            // Convert the input word to a character array
            char[] characters = inputWord.ToCharArray();

            // Create a new instance of Random
            Random random = new Random();

            // Shuffle the characters using Fisher-Yates algorithm
            for (int i = characters.Length - 1; i > 0; i--)
            {
                // Randomly select an index within the remaining unshuffled characters
                int j = random.Next(0, i + 1);

                // Swap the characters at indices i and j
                char temp = characters[i];
                characters[i] = characters[j];
                characters[j] = temp;
            }

            // Randomize the letter case of each character
            for (int i = 0; i < characters.Length; i++)
            {
                if (random.Next(0, 2) == 0)
                {
                    // Convert to uppercase
                    characters[i] = char.ToUpper(characters[i]);
                }
                else
                {
                    // Convert to lowercase
                    characters[i] = char.ToLower(characters[i]);
                }
            }

            // Convert the shuffled character array back to a string and return it
            return new string(characters);
        }
    }
}
