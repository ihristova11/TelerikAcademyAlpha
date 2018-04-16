namespace _004.Passwords
{
    using System;

    public class Program
    {
        private static char[] symbols;
        private static int[] comb;
        private static int n;
        private static int k;
        private static int counter = 0;

        public static void Main()
        {
            n = int.Parse(Console.ReadLine());
            comb = new int[n];
            symbols = Console.ReadLine().ToCharArray();
            k = int.Parse(Console.ReadLine());

            FindPossiblePasswords();
        }

        private static void FindPossiblePasswords()
        {
            for (int i = 0; i < 10; i++)
            {
                comb[0] = i;
                FindCombinations(i, 0);
            }
        }

        private static void FindCombinations(int currentDigit, int directionIndex)
        {
            if (directionIndex >= n)
            {
                return;
            }

            comb[directionIndex] = currentDigit;
            if (directionIndex == n - 1)
            {
                counter++;
                if (counter == k)
                {
                    Console.WriteLine(string.Join(string.Empty, comb).PadLeft(n, '0'));

                    Environment.Exit(0);
                }

                return;
            }

            if (symbols[directionIndex] == '=')
            {
                FindCombinations(currentDigit, directionIndex + 1);
            }
            else if (symbols[directionIndex] == '>')
            {
                if (currentDigit == 0)
                {
                    return;
                }

                FindCombinations(0, directionIndex + 1);

                for (int i = currentDigit + 1; i < 10; i++)
                {
                    FindCombinations(i, directionIndex + 1);
                }
            }
            else
            {
                if (currentDigit == 0)
                {
                    for (int i = 1; i <= 9; i++)
                    {
                        FindCombinations(i, directionIndex + 1);
                    }
                }
                else
                {
                    for (int i = 1; i < currentDigit; i++)
                    {
                        FindCombinations(i, directionIndex + 1);
                    }
                }
            }
        }
    }
}