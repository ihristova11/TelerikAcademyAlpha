﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LongestSubsequence
{
    public class LongestSubsequence
    {
        public static void Main()
        {
            Console.WriteLine("Input numbers: ");
            var numbers = new List<int>();
            var inputLine = Console.ReadLine();

            while (inputLine != string.Empty)
            {
                var number = int.Parse(inputLine);
                numbers.Add(number);
                inputLine = Console.ReadLine();
            }

            Console.WriteLine("The longest sequence of equal numbers is: ");
            var list = GetLongestEqualSubsequence(numbers);
            list.ForEach(n => Console.Write("{0} ", n));
            Console.WriteLine();
        }

        public static List<int> GetLongestEqualSubsequence(IList<int> numbersList)
        {
            var longestSubsequence = 0;
            var currentSubsequence = 0;
            var subsequenceNumber = 0;

            for (var i = 0; i < numbersList.Count(); i++)
            {
                var currentElement = numbersList[i];

                if (i == 0)
                {
                    currentSubsequence = 1;
                }
                else
                {
                    var previousElement = numbersList[i - 1];

                    if (currentElement != previousElement)
                    {
                        currentSubsequence = 1;
                    }
                    else
                    {
                        ++currentSubsequence;
                    }
                }

                if (currentSubsequence > longestSubsequence)
                {
                    longestSubsequence = currentSubsequence;
                    subsequenceNumber = currentElement;
                }
            }

            return Enumerable.Repeat(subsequenceNumber, longestSubsequence).ToList();
        }
    }
}