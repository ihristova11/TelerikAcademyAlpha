namespace _08.ExtractSentences
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ExtractSentences
    {
        static void Main()
        {
            //reading the input
            //string word = Console.ReadLine();
            //string input = Console.ReadLine();
            string text = "some text in here intherein";
            string pattern = @"\bin\s";
            Regex rg = new Regex(pattern);
            MatchCollection col = rg.Matches(text);
            foreach (Match match in col)
            {

                Console.WriteLine(match.Value);
            }
        }
    }
}
