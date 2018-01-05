using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SpellCaster
{
    class SpellCaster
    {
        static void Main(string[] args)
        {
            //Step 1
            string[] sentence = Console.ReadLine().Split();
            int longestWord = FindLongestWordLength(sentence);
            string extracted = ExtractingLastCharacters(sentence, longestWord);
            //Step 2
            char[] result = extracted.ToCharArray();
            result = MovingCharacters(result);
            foreach (var letter in result)
            {
                Console.Write(letter);
            }

        }
        static int FindLongestWordLength(string[] sentence)
        {
            int longestWord = 0;
            foreach (var word in sentence)
            {
                if (word.Length > longestWord)
                {
                    longestWord = word.Length;
                }
            }
            return longestWord;
        }
        static string ExtractingLastCharacters(string[] sentence, int longestWord)
        {
            string extracted = string.Empty;
            for (int i = 0; i < longestWord; i++) //loop for extracting the last characters in words
            {
                for (int j = 0; j < sentence.Length; j++) //loop for switching the words in sentence
                {
                    string temp = sentence[j];
                    if (temp.Length - i - 1 >= 0) //temp.Length-i-1 moving from temp[temp.length-1] to temp[0]
                    {
                        extracted += temp[temp.Length - i - 1]; //adding the extracted charaters to the string
                    }
                }
            }
            return extracted;
        }
        static char[] MovingCharacters(char[] result)
        {
            for (int i = 0; i < result.Length; i++) // int i = current position in the array
            {
                int letterValue = char.ToLower(result[i]) - 'a' + 1; //giving the letters the Latin alphabet value
                int position = letterValue + i; //the new position of the current character
                if (position > result.Length - 1) //the position of the character if it's>result[lastindex]
                {
                    position %= result.Length;
                }

                if (i < position)
                {
                    result = MovingCharFromLeftToRight(result, position, i);
                }
                else if (position < i)
                {
                    result = MovingCharFromRightToLeft(result, position, i);
                }
            }
            return result;
        }
        static char[] MovingCharFromLeftToRight(char[] result, int position, int i)
        {
            for (int j = i; j < position; j++)
            {
                char temp = result[j];
                result[j] = result[j + 1];
                result[j + 1] = temp;
            }
            return result;
        }
        static char[] MovingCharFromRightToLeft(char[] result, int position, int i)
        {
            for (int j = i; j > position; j--)
            {
                char temp = result[j];
                result[j] = result[j - 1];
                result[j - 1] = temp;
            }
            return result;
        }
    }
}