using System;
using System.Linq;

namespace _04.Passwords
{
    public class Passwords
    {
        private static char[] symbols;
        private static int[] digits;
        private static int[] comb;
        private static int n;
        private static int k;

        public static void Main()
        {
            var line = Console.ReadLine().Split(' ');
            n = int.Parse(line[0]);
            comb = new int[n];
            symbols = line[1].ToCharArray();
            k = int.Parse(line[2]);

            digits = Enumerable.Range(1, 10).ToArray();
            digits[9] = 0;

            Recursion(0);
        }

        private static void Recursion(int start)
        {
            if (n == start)
            {
                if (--k == 0) // only one -> to be printed
                {
                    Console.WriteLine(string.Join("", comb));
                }

                return;
            }

            if (start > 0)
            {
                if (symbols[start - 1] == '=')
                {
                    comb[start] = comb[start - 1];
                    Recursion(start + 1);

                }
                else if (symbols[start - 1] == '>')
                {
                    var s = comb[start - 1];

                    if (s == 0)
                    {
                        return;
                    }

                    comb[start] = 0;
                    Recursion(start + 1);

                    int j = s;
                    if (s == 0) j = n;

                    for (; j < 9; j++)
                    {
                        comb[start] = digits[j];
                        Recursion(start + 1);
                    }
                }
                else if (symbols[start - 1] == '<')
                {
                    var s = comb[start - 1];

                    if (s == 0) s = 10;

                    for (int j = 0; j < s - 1; j++)
                    {
                        comb[start] = digits[j];
                        Recursion(start + 1);
                    }
                }
            }
            else
            {
                comb[start] = 0;
                Recursion(start + 1);

                for (int i = start; i < 9; i++)
                {
                    comb[start] = digits[i];
                    Recursion(start + 1);
                }
            }
        }
    }
}