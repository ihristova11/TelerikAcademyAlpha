using System;
using System.Collections.Generic;
using System.Text;

namespace _006.GirlsGoneWild
{
    public class Program
    {
        private static int[] combinations;
        private static int numberOfPeople;
        private static char[] shirtTypes;

        public static void Main()
        {
            int shirts = int.Parse(Console.ReadLine());
            char[] skirts = Console.ReadLine().ToCharArray();
            int girls = int.Parse(Console.ReadLine());
            List<List<int>> shirtsCombinations = new List<List<int>>();
            Skirts skirtsCombinations = new Skirts();

            CombineShirts(shirts, girls, 0, new List<int>(), shirtsCombinations);
            CombineSkirts(skirts, girls, new HashSet<int>(), -1, new List<char>(), skirtsCombinations);

            List<string> output = new List<string>();
            Console.WriteLine(shirtsCombinations.Count * skirtsCombinations.SkirtsCombinations.Count);

            StringBuilder sb = new StringBuilder();

            foreach (var shirtCombination in shirtsCombinations)
            {
                foreach (var skirtCombination in skirtsCombinations.SkirtsCombinations)
                {
                    for (int i = 0; i < girls; i++)
                    {
                        sb.Append(shirtCombination[i].ToString());
                        sb.AppendLine(skirtCombination[i].ToString());
                    }
                }
            }

            Console.WriteLine(sb);
        }

        private static void CombineShirts(int max, int girls, int currentShirt, List<int> currentCombination,
            List<List<int>> shirtsCombinations)
        {
            if (currentCombination.Count == girls)
            {
                shirtsCombinations.Add(new List<int>(currentCombination));
                return;
            }

            for (int i = 0; i < max; i++)
            {
                currentCombination.Add(i);
                CombineShirts(max, girls, i + 1, currentCombination, shirtsCombinations);
                currentCombination.Remove(currentCombination.Count - 1);
            }
        }

        private static void CombineSkirts(char[] skirts, int girls, HashSet<int> usedIndeces, int currentSkirtIndex,
            List<char> currentCombination, Skirts skirtsCombination)
        {
            if (currentCombination.Count == girls)
            {
                if (!skirtsCombination.UniqueSkirtsCombinations.Contains(currentCombination))
                {
                    skirtsCombination.SkirtsCombinations.Add(currentCombination);
                    skirtsCombination.UniqueSkirtsCombinations.Add(currentCombination);
                }

                return;
            }

            for (int i = 0; i < skirts.Length; i++)
            {
                if (usedIndeces.Contains(i))
                {
                    continue;
                }

                usedIndeces.Add(i);
                char currentSkirt = skirts[i];
                currentCombination.Add(currentSkirt);
                CombineSkirts(skirts, girls, usedIndeces, i, currentCombination, skirtsCombination);
                usedIndeces.Remove(i);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }

    public class Skirts
    {
        public List<List<char>> SkirtsCombinations = new List<List<char>>();
        public HashSet<List<char>> UniqueSkirtsCombinations = new HashSet<List<char>>();
    }
}
