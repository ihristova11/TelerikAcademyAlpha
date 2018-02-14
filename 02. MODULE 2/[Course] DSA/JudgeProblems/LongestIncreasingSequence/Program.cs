using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSequence
{
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            var sequence = GetLongestSequence(numbers);
            Console.WriteLine(sequence);
        }

        private static int GetLongestSequence(List<int> numbers)
        {
            int lastSequenceIndex = 0;
            int longestSequenceLenght = 1;
            int tempLenght = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] - 1 == numbers[i - 1])
                {
                    ++tempLenght;
                    if (tempLenght > longestSequenceLenght)
                    {
                        longestSequenceLenght = tempLenght;
                        lastSequenceIndex = i;
                    }
                }
                else
                {
                    tempLenght = 1;
                }
            }

            int skip = lastSequenceIndex - longestSequenceLenght + 1;
            var sequence = numbers.Skip(skip).Take(longestSequenceLenght).ToArray();
            return sequence.Length;
        }
}
