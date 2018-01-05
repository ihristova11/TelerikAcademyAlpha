using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestString
{
    public class LongestString
    {
        static void Main()
        {
            string sentece = "My name is Irinaaaaaaaaaa Hristova.";

            List<string> words = sentece.Split(' ', '.').ToList();

            var wordsLen = words.Select(w => w.Length);

            Console.WriteLine(string.Join(" ", words.Where(w => w.Length == wordsLen.Max())));
        }
    }
}
