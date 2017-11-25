namespace _08.ExtractSentences
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ExtractSentences
    {
        static void Main()
        {            
            string searched = Console.ReadLine();
            string sentences = Console.ReadLine();

            string wordPattern = @"(\bin\s)";
            string sentencePattern = @"(\S.+?[.!?])(?=\s+|$)";
            Regex sentenceRG = new Regex(sentencePattern);
            Regex wordRG = new Regex(wordPattern);

            MatchCollection matched = sentenceRG.Matches(sentences);
            foreach (var item in matched)
            {
                if (wordRG.IsMatch(item.ToString()))
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
