namespace _08.ExtractSentences
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractSentences
    {
        static void Main()
        {
            //reading the input
            string input = Console.ReadLine();

            //constructing the pattern to be matched
            Regex rg = new Regex(@"(\S.+?[.!?])(?=\s+|$)");

            //iterating through the matches and printing them
            foreach (Match match in rg.Matches(input))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
