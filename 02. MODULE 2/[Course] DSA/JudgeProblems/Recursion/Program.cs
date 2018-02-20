using System;
using System.Linq;

namespace Recursion
{
    public class Program
    {
        static void Main()
        {
            var moves = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var fromTo = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int a = fromTo[0];
            int b = fromTo[1];
            int result = 0;

            for (int i = a; i <= b; i++)
            {
                if (FindWinner(i, moves))
                {
                    ++result;
                }
            }

            Console.WriteLine(result);
        }

        static bool FindWinner(int balls, int[] moves)
        {
            if (balls == 0)
            {
                return false;
            }

            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] > balls)
                {
                    continue;
                }

                if (!FindWinner(balls - moves[i], moves))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
