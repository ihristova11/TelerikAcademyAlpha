namespace _02.PrimeTriangle
{
    using System;
    using System.Text;

    class PrimeTriangle
    {
        static void Main()
        {

        }

        // method for finding prime number
        static void FindPrimeNumber(int n)
        {
            int i = 2;
            while(n != 0)
            {
                n = n / i;
                i++;
            }
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
