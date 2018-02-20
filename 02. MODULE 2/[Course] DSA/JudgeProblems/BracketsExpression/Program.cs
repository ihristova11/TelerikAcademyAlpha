using System;
using System.Collections.Generic;
using System.Text;
namespace SecretMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var substrings = new List<string>();
            var numbers = new List<int>();
            var openingIndexes = new Stack<int>();
            var counts = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (current == '{')
                {
                    openingIndexes.Push(i);
                    var sb = new StringBuilder();
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (char.IsDigit(input[j]))
                        {
                            sb.Insert(0, input[j]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    counts.Push(int.Parse(sb.ToString()));
                }
                else if (current == '}')
                {
                    int open = openingIndexes.Pop();
                    string sub = input.Substring(open, (i - open) + 1);
                    substrings.Add(sub);
                    numbers.Add(counts.Pop());
                }
            }
            substrings.Add(input);
            for (int i = 0; i < substrings.Count - 1; i++)
            {
                var current = substrings[i];
                var num = numbers[i];
                string old = num + current;
                var strBuilder = new StringBuilder();
                string middle = current.Substring(1, current.Length - 2);
                for (int c = 0; c < num; c++)
                {
                    strBuilder.Append(middle);
                }
                string newStr = strBuilder.ToString();
                for (int j = i + 1; j < substrings.Count; j++)
                {
                    if (substrings[j].Contains(old))
                    {
                        substrings[j] = substrings[j].Replace(old, newStr);
                    }
                }
            }
            Console.WriteLine(substrings[substrings.Count - 1]);
        }
    }
}

