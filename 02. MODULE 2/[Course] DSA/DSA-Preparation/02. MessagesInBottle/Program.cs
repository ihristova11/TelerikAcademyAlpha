using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.MessagesInBottle
{
    public class Program
    {
        static void Main()
        {
            string secretCode = Console.ReadLine();
            string cipher = Console.ReadLine();
            string pattern = @"([A-Z]+)(\d+)";
            StringBuilder decodedMessage = new StringBuilder();
            Dictionary<string, string> letterToCode = new Dictionary<string, string>();
            SortedSet<string> sortedMsg = new SortedSet<string>();
            MatchCollection matches = Regex.Matches(cipher, pattern);
            foreach (Match match in matches)
            {
                char letter = match.Groups[1].Value[0];
                string code = match.Groups[2].Value;

                if (!letterToCode.ContainsKey(letter.ToString()))
                {
                    letterToCode.Add(letter.ToString(), code);
                }
            }
            Decode(decodedMessage, letterToCode, sortedMsg, secretCode);

            Console.WriteLine(sortedMsg.Count);
            if (sortedMsg.Count > 0)
            {
                Console.WriteLine(string.Join("\n", sortedMsg));
            }
        }

        private static void Decode(StringBuilder decodedMessage, Dictionary<string, string> letterToCode, SortedSet<string> sortedMsg, string secretMessage)
        {
            //bottom of recursion
            if (secretMessage.Length == 0)
            {
                sortedMsg.Add(decodedMessage.ToString());
                return;
            }

            foreach (var pair in letterToCode)
            {
                string letter = pair.Key;
                string code = pair.Value;

                if (secretMessage.StartsWith(code))
                {
                    decodedMessage.Append(letter);

                    string sub = secretMessage.Substring(code.Length);
                    Decode(decodedMessage, letterToCode, sortedMsg, sub);

                    decodedMessage.Remove(decodedMessage.Length - 1, 1);
                }
            }
        }
    }
}
