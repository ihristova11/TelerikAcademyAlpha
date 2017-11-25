namespace _08.ExtractSentences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class ExtractSentences
    {
        static void Main()
        {
            string searched = Console.ReadLine();
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            List<string> sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            char[] sep = text.Where(l => !char.IsLetter(l)).Distinct().ToArray();

            List<string> words = new List<string>();

            foreach (var sentence in sentences)
            {
                words = sentence.Split(sep, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (words.Contains(searched))
                {
                    sb.Append(sentence.Trim());
                    sb.Append(". ");
                }
            }
            Console.WriteLine(sb.ToString().Trim());

            //string searched = Console.ReadLine();
            //string sentences = Console.ReadLine();

            //string wordPattern = @"(\sin\s)";
            //string sentencePattern = @"(\S.+?[.!?])(?=\s+|$)";

            //Regex sentenceRG = new Regex(sentencePattern);
            //Regex wordRG = new Regex(wordPattern);

            //MatchCollection matched = sentenceRG.Matches(sentences);

            //List<string> res = new List<string>();

            //foreach (var item in matched)
            //{
            //    if (wordRG.IsMatch(item.ToString()))
            //    {
            //        res.Add(item.ToString());
            //    }
            //}

            //Console.WriteLine(string.Join(" ", res));

        }
    }
}
