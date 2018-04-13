using System;
using System.Linq;

namespace _08.Portals
{
    public class Program
    {
        private static int max = 0;
        private static int[,] matrix;
        private static bool[,] visited;

        static void Main()
        {
            var xY = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rC = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var x = xY[0];
            var y = xY[1];

            var r = rC[0];
            var c = rC[1];

            matrix = new int[r, c];
            visited = new bool[r, c];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine().Split(' ');

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!int.TryParse(line[col], out matrix[row, col]))
                    {
                        matrix[row, col] = -1;
                    }
                }
            }

            Recursion(0, x, y);

            Console.WriteLine(max);
        }

        static void Recursion(int portalPowerSum, int row, int col)
        {
            if (visited[row, col])
            {
                return;
            }

            var portalPower = matrix[row, col];
            if (!(CheckCoordinates(row + portalPower, col) || // down
                  CheckCoordinates(row - portalPower, col) || // up
                  CheckCoordinates(row, col + portalPower) || // right
                  CheckCoordinates(row, col - portalPower))) // left
            {
                return;
            }


            portalPowerSum += portalPower;
            max = Math.Max(max, portalPowerSum);

            visited[row, col] = true;

            if (CheckCoordinates(row + portalPower, col))
            {
                Recursion(portalPowerSum, row + portalPower, col);
            }

            if (CheckCoordinates(row - portalPower, col))
            {
                Recursion(portalPowerSum, row - portalPower, col);
            }

            if (CheckCoordinates(row, col + portalPower))
            {
                Recursion(portalPowerSum, row, col + portalPower);
            }

            if (CheckCoordinates(row, col - portalPower))
            {
                Recursion(portalPowerSum, row, col - portalPower);
            }

            visited[row, col] = false;
        }

        static bool CheckCoordinates(int row, int col)
        {
            var can = row > -1 && col > -1 &&
                   row < matrix.GetLength(0) &&
                   col < matrix.GetLength(1) &&
                   matrix[row, col] > -1;
            
            return can;
        }
    }
}