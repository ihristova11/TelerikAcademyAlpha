using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAreaInMatrix
{
    class Program
    {
        private static int[] Rows = { 1, -1, 0, 0 };
        private static int[] Cols = { 0, 0, -1, 1 };

        static void Main(string[] args)
        {
            var rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToList();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] graph = new int[rows, cols];
            bool[,] visited = new bool[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var row = Console.ReadLine().Split().Select(int.Parse).ToList();
                for (int j = 0; j < cols; j++)
                {
                    graph[i, j] = row[j];
                }
            }

            int largestArea = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!visited[i, j])
                    {
                        int area = RecursiveDfs(i, j, graph, visited);
                        if (largestArea < area)
                        {
                            largestArea = area;
                        }
                    }
                }
            }

            Console.WriteLine(largestArea);
        }

        private static int Bfs(int row, int col, int[,] graph, bool[,] visited)
        {
            int count = 0;

            Node startNode = new Node() { Row = row, Col = col };
            visited[startNode.Row, startNode.Col] = true;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(startNode);

            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                count++;

                foreach (Node neighbour in GetNeighbours(node, graph))
                {
                    if (!visited[neighbour.Row, neighbour.Col])
                    {
                        queue.Enqueue(neighbour);
                        visited[neighbour.Row, neighbour.Col] = true;
                    }
                }
            }

            return count;
        }

        private static int IterativeDfs(int row, int col, int[,] graph, bool[,] visited)
        {
            int count = 0;

            Node startNode = new Node() { Row = row, Col = col };
            visited[startNode.Row, startNode.Col] = true;

            Stack<Node> stack = new Stack<Node>();
            stack.Push(startNode);

            while (stack.Count > 0)
            {
                Node node = stack.Pop();
                count++;

                foreach (Node neighbour in GetNeighbours(node, graph))
                {
                    if (!visited[neighbour.Row, neighbour.Col])
                    {
                        stack.Push(neighbour);
                        visited[neighbour.Row, neighbour.Col] = true;
                    }
                }
            }

            return count;
        }

        private static int RecursiveDfs(int row, int col, int[,] graph, bool[,] visited)
        {
            int count = 1;
            Node node = new Node() { Row = row, Col = col };
            visited[node.Row, node.Col] = true;

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
                Node neighbour = new Node() { Row = node.Row + Rows[i], Col = node.Col + Cols[i] };
                if (IsValid(neighbour.Row, neighbour.Col, graph.GetLength(0), graph.GetLength(1))
                 && graph[node.Row, node.Col] == graph[neighbour.Row, neighbour.Col])
                {
                    neighbours.Add(neighbour);
                }
            }

            return neighbours;
        }

        private static bool IsValid(int row, int col, int rows, int cols)
        {
            return row > -1 && row < rows && col > -1 && col < cols;
        }
    }

    public class Node
    {
        public int Row { get; set; }

        public int Col { get; set; }
    }
}