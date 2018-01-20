using System;
using System.Collections.Generic;
using System.Linq;

namespace Slogan
{
    // similar to author's solution
    // similar to Message in Bottle solution

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var suggestedWords = Console.ReadLine()
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string sloganToTry = Console.ReadLine();

                List<string> usedWords = new List<string>();
                HashSet<string> impossibles = new HashSet<string>();
                if (GenerateVariants(suggestedWords, sloganToTry, usedWords, impossibles))
                {
                    usedWords.Reverse();
                    Console.WriteLine(string.Join(" ", usedWords));
                }
                else
                {
                    Console.WriteLine("NOT VALID");
                }
            }
        }

        private static bool GenerateVariants(IList<string> suggestions, string sloganToTry,
            IList<string> usedWords, HashSet<string> impossibles)
        {
            if (sloganToTry.Length < 1)
            {
                // bottom of recursion
                return true;
            }

            if (impossibles.Contains(sloganToTry))
            {
                // optimization for time
                // stops the recursion
                return false; 
            }

            foreach (var word in suggestions)
            {
                if (sloganToTry.StartsWith(word))
                {
                    string subSlogan = sloganToTry.Substring(word.Length);

                    if (GenerateVariants(suggestions, subSlogan, usedWords, impossibles))
                    {
                        usedWords.Add(word);
                        return true;
                    }
                }
            }
            impossibles.Add(sloganToTry);
            return false;
        }
    }
}


