namespace _02.PrimeTriangle
{
    using System;
    using System.Text;

    class PrimeTriangle
    {
        static int n;
        static StringBuilder line = new StringBuilder("1");
        static int count = 1;
        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(line); // print the first line
            for (count = 2; count <= n; count++)
            {
                bool result = FindPrimeNumber(count);
                if (result == true)
                {
                    line.Append(1);
                    Console.WriteLine(line);
                }
                else
                {
                    line.Append(0);
                }
            }
        }

        // method for finding if number is prime
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
    }
}
