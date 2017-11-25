namespace _08.ExtractSentences
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractSentences
    {
        static void Main()
        {
            //reading the input
            string searchedWord = Console.ReadLine();
            string input = Console.ReadLine();

            //constructing the pattern to be matched
            Regex rg = new Regex(@"(\S.+?[.!?])(?=\s+|$)");
            Regex wordMatch = new Regex(@"^(.*?(\bpass\b)[^$]*)$");
            //iterating through the matches and printing them
            foreach (Match match in rg.Matches(input))
            {
                foreach (Match word in wordMatch.Matches(match.Value))
                {
                    Console.WriteLine(match.Value);
                }
                //Console.WriteLine(match.Value);
            }
        }
    }
}
