namespace _02.PrimeTriangle
{
    using System;
    using System.Text;

    class PrimeTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = int.Parse(FindPrimeNumber(n).ToString());
        }

        // method for finding prime number
        static bool FindPrimeNumber(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;

            if (n % 2 == 0) return false;
            for (int i = 2;i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // method for printing all numbers in a line
        static void PrintLine(int num)
        {
            StringBuilder line = new StringBuilder();
            for (int i = 1; i <= num; i++)
            {
                line = line.Append(i);
            }
        }
    }
}
