using System;

namespace _02.Legs
{
    class Legs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int N = n;
            int powerSeven = 0;
            int powerFive = 0;

            powerSeven = n / 7;
            if(n % 7 == 0 && n > 6)
            {
                powerSeven--;
                count++;
            }
            //Console.WriteLine("OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
            for (int i = powerSeven; i >= 0; i--)
            {
                n = n - i * 7;
                powerFive = n / 5;
                if (n % 5 == 0 && n > 4)
                {
                    powerFive--;
                    count++;
                }
                //Console.WriteLine("---------------------------------------------------FOR1");
                //Console.WriteLine("i= " + i + " n=" + n + " c=" + count);
                //Console.WriteLine("_____________________________________________");
                for (int k = powerFive; k >= 0; k--)
                {
                    n = n - k * 5;
                    //Console.WriteLine("i= " + i + " n=" + n + " k=" + k + " c=" + count);
                    if (n % 2 == 0 && n != 0)
                    {
                        count++;
                    }

                    n = N - i * 7;
                }
                n = N;
            }

            Console.WriteLine(count);
        }
    }
}
