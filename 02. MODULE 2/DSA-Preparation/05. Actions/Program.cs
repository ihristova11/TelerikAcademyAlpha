using System;
using System.Collections.Generic;
using System.Linq;

namespace Actions
{
    public class Node<T>
    {
        public int ParentCount { get; set; }

        public bool IsVisited { get; set; }

        public List<T> Childs { get; set; }
    }

    public class Program
    {
        static void Main()
        {
            // read the input
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = input[0];
            int m = input[1];

            List<int>[] childs = new List<int>[n];
            int[] parentsCount = new int[n];
            bool[] visited = new bool[n];

            ReadGraph(m, childs, parentsCount);
            TopologicalSort(childs, parentsCount, visited);
        }

        private static void ReadGraph(int m, List<int>[] childs, int[] parentsCount)
        {
            for (int i = 0; i < m; i++)
            {
                var pair = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                int parent = pair[0];
                int child = pair[1];

                parentsCount[child]++;

                if (childs[parent] == null)
                {
                    childs[parent] = new List<int>();
                }

                childs[parent].Add(child);
            }
        }

        private static void TopologicalSort(List<int>[] childs, int[] parentsCount, bool[] visited)
        {
            bool areAllVisited = false;
            while (!areAllVisited)
            {
                areAllVisited = true;

                for (int i = 0; i < visited.Length; i++)
                {
                    if (parentsCount[i] == 0 && !visited[i])
                    {
                        Console.WriteLine(i);
                        visited[i] = true;

                        if (childs[i] != null)
                        {
                            foreach (int child in childs[i])
                            {
                                parentsCount[child]--;
                            }
                        }

                        areAllVisited = false;
                        break;
                    }
                }
            }
        }
    }
}
