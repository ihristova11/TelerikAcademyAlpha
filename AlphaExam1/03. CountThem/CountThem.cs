using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CountThem
{
    class CountThem
    {
        static void Main(string[] args)
        {
            string singleLine = @"\/\/.*|\#.*";
            string multiLine = @"\/\*.*\*\/";
            var singleLineMatcher = new Regex(singleLine);
            var multiLineMatcher = new Regex(multiLine);
            var strBr = new StringBuilder();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == @"{!}")
                {
                    break;
                }
                else
                {
                    var singleMatches = singleLineMatcher.Matches(input);
                    {
                        foreach (Match match in singleMatches)
                        {
                            input = input.Replace(match.ToString(), string.Empty);
                        }
                    }

                    strBr.Append(input);
                }
            }

            var correctedInput = strBr.ToString();

            var multiMatches = multiLineMatcher.Matches(correctedInput);
            foreach (Match match in multiMatches)
            {
                correctedInput = correctedInput.Replace(match.ToString(), string.Empty);
            }

            var otherSymbols = new Regex(@"\\\\");

            var otherSymbolsCollection = otherSymbols.Matches(correctedInput);

            foreach (Match match in otherSymbolsCollection)
            {
                correctedInput = correctedInput.Replace(match.ToString(), string.Empty);
            }

            var variableMatcher = new Regex(@"(\\@|@)(_|[a-zA-Z])[a-zA-Z|0-9|_]+");
            var variableMatchesCollection = variableMatcher.Matches(correctedInput);

            List<string> variables = new List<string>();
            foreach (Match match in variableMatchesCollection)
            {
                if (!match.ToString().StartsWith(@"\"))
                {
                    variables.Add(match.ToString().TrimStart('@'));
                }
            }
            variables = variables.Distinct().ToList();
            variables.Sort();

            Console.WriteLine(variables.Count);

            foreach (var str in variables)
            {
                Console.WriteLine(str);
            }
        }
    }
}