using System;

namespace PathToOne
{
   public class PathToOne
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine()); // get the number 

            Console.WriteLine(FindPower(n));

            // -- first idea (needed changes) 
            //int down = 1;
            //int power = 0;
            //int result;
            //while (n > down)
            //{
            //    down *= 2;
            //    ++power;
            //}
            //down /= 2;
            //--power;

            //int up = down * 2;

            //if (n - down < up - n) // if down is closer to n
            //{
            //    result = power + n - down;
            //}
            //else // if up is closer to n
            //{
            //    ++power;
            //    result = power + up - n;
            //}

            //Console.WriteLine(result);
        }

        public static int FindPower(uint n, int depth = 0)
        {
            if (n == 1) return depth;

            if (n % 2 == 0)
            {
                return FindPower(n / 2, depth + 1);
            }
            else
            {
                int firstCase = FindPower(n + 1, depth + 1);
                int secondCase = FindPower(n - 1, depth + 1);
                return Math.Min(firstCase, secondCase);
            }
        }
    }
}
