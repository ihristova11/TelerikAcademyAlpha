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
                int result = int.Parse(FindPrimeNumber(count).ToString());
                if (result == 1)
                {
                    
                }
                else
                {

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

        // method for printing all numbers in a line
        static void PrintLine(int num)
        {            
            for (int i = count; i <= num; i++)
            {
                line = line.Append(i);
            }
        }
    }
}
