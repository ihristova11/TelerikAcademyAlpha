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
            var parameters = Console.ReadLine().Split(' ');
            n = int.Parse(parameters[0]);
            comb = new int[n];
            symbols = parameters[1].ToCharArray();
            k = int.Parse(parameters[2]);

            for (int i = 0; i < 10; i++)
            {
                comb[0] = i;
                FindCombinations(i, 0);
            }
        }

        private static int FindCombinations(int currentDigit, int directionIndex)
        {
            if (directionIndex >= n)
            {
                return 0;
            }

            comb[directionIndex] = currentDigit;
            if (directionIndex == n - 1)
            {
                counter++;
                if (counter == k)
                {
                    Console.WriteLine(string.Join(string.Empty, comb).PadLeft(n, '0'));

                    return 0;
                }

                return 0;
            }

            if (symbols[directionIndex] == '=')
            {
                FindCombinations(currentDigit, directionIndex + 1);
                return 0;
            }
            else if (symbols[directionIndex] == '>')
            {
                if (currentDigit == 0)
                {
                    return 0;
                }

                FindCombinations(0, directionIndex + 1);

                for (int i = currentDigit + 1; i < 10; i++)
                {
                    FindCombinations(i, directionIndex + 1);
                }

                return 0;
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

                return 0;
            }
        }
    }
}
