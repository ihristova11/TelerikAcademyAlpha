using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestAreaInMatrix
{
    class Program
    {
        private static int[] Rows = { 1, -1, 0, 0 };
        private static int[] Cols = { 0, 0, -1, 1 };

        public class Node
        {
            public int Row { get; set; }

            public int Col { get; set; }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];
            bool[,] visited = new bool[rows, cols];


            // fill the matrix
            for (int i = 0; i < rows; i++)
            {
                var row = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int largestArea = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!visited[i, j])
                    {
                        int area = RecursiveDfs(i, j, matrix, visited);
                        largestArea = largestArea < area ? area : largestArea;
                    }
                }
            }

            Console.WriteLine(largestArea);
        }

        private static int RecursiveDfs(int row, int col, int[,] graph, bool[,] visited)
        {
            int count = 1;
            Node node = new Node() { Row = row, Col = col }; // current cell 
            visited[node.Row, node.Col] = true; // mark current cell as visited 

            foreach (Node neighbour in GetNeighbours(node, graph))
            {
                if (!visited[neighbour.Row, neighbour.Col])
                {
                    count += RecursiveDfs(neighbour.Row, neighbour.Col, graph, visited);
                }
            }

            return count;
        }

        private static IEnumerable<Node> GetNeighbours(Node node, int[,] graph)
        {
            List<Node> neighbours = new List<Node>();

            for (int i = 0; i < Rows.Length; i++)
            {
                Node neighbour = new Node() { Row = node.Row + Rows[i], Col = node.Col + Cols[i] }; // create the new neighbour in possible directions

                if (IsValid(neighbour.Row, neighbour.Col, graph.GetLength(0), graph.GetLength(1)) // find equal neighbours
                 && graph[node.Row, node.Col] == graph[neighbour.Row, neighbour.Col])
                {
                    neighbours.Add(neighbour);
                }
            }

            return neighbours;
        }

        private static bool IsValid(int row, int col, int rows, int cols) // check if out of boundaries of the matrix
        {
            return row > -1 && row < rows && col > -1 && col < cols; 
        }
    }
}
