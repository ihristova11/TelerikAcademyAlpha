using System;
using System.Collections.Generic;

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
        }

        public class Skirts
        {
            List<List<char>> skirtsCombinations = new List<List<char>>();
            HashSet<List<char>> uniqueSkirtsCombinations = new HashSet<List<char>>();
        }
    }
}
