using System;
using System.Collections.Generic;
using System.Linq;

namespace Actions
{
    class Program
    {
        static void Main(string[] args)
        {
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
                var pair = Console.ReadLine().Split().Select(int.Parse).ToList();
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

        private static Dictionary<int, Node<int>> ReadGraph(int m, int n)
        {
            Dictionary<int, Node<int>> graph = new Dictionary<int, Node<int>>();

            for (int i = 0; i < n; i++)
            {
                graph[i] = new Node<int>();
            }

            for (int i = 0; i < m; i++)
            {
                var pair = Console.ReadLine().Split().Select(int.Parse).ToList();
                int parent = pair[0];
                int child = pair[1];

                if (graph[parent].Childs == null)
                {
                    graph[parent].Childs = new List<int>();
                }

                graph[parent].Childs.Add(child);
                graph[child].ParentCount++;
            }

            return graph;
        }

        private static IDictionary<T, Node<T>> ReadGraph<T>(int m, int n, Func<string, T> parse)
        {
            SortedDictionary<T, Node<T>> graph = new SortedDictionary<T, Node<T>>();

            for (int i = 0; i < m; i++)
            {
                var pair = Console.ReadLine().Split().ToList();
                T parent = parse(pair[0]);
                T child = parse(pair[1]);

                if (!graph.ContainsKey(parent))
                {
                    graph[parent] = new Node<T>();
                }

                if (!graph.ContainsKey(child))
                {
                    graph[child] = new Node<T>();
                }

                if (graph[parent].Childs == null)
                {
                    graph[parent].Childs = new List<T>();
                }

                graph[parent].Childs.Add(child);
                graph[child].ParentCount++;
            }

            return graph;
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

        private static void TopologicalSort(Dictionary<int, Node<int>> graph)
        {
            bool areAllVisited = false;
            while (!areAllVisited)
            {
                areAllVisited = true;
                for (int i = 0; i < graph.Keys.Count; i++)
                {
                    Node<int> node = graph[i];
                    if (node.ParentCount == 0 && !node.IsVisited)
                    {
                        Console.WriteLine(i);
                        node.IsVisited = true;
                        if (node.Childs != null)
                        {
                            foreach (int childKey in node.Childs)
                            {
                                graph[childKey].ParentCount--;
                            }
                        }

                        areAllVisited = false;
                        break;
                    }
                }
            }
        }

        private static void TopologicalSort<T>(IDictionary<T, Node<T>> graph)
        {
            bool areAllVisited = false;
            while (!areAllVisited)
            {
                areAllVisited = true;
                foreach (var pair in graph)
                {
                    Node<T> node = pair.Value;
                    if (node.ParentCount == 0 && !node.IsVisited)
                    {
                        Console.WriteLine(pair.Key);
                        node.IsVisited = true;
                        if (node.Childs != null)
                        {
                            foreach (T childKey in node.Childs)
                            {
                                graph[childKey].ParentCount--;
                            }
                        }

                        areAllVisited = false;
                        break;
                    }
                }
            }
        }

        private static void UpdateGraph(int n, IDictionary<int, Node<int>> graph)
        {
            for (int i = 0; i < n; i++)
            {
                if (!graph.ContainsKey(i))
                {
                    graph[i] = new Node<int>();
                }
            }
        }

        private static void BubbleSort(List<int> numbers)
        {
            bool swapped = false;
            while (!swapped)
            {
                swapped = true;
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        swapped = false;
                    }
                }
            }
        }
    }

    public class Node<T>
    {
        public int ParentCount { get; set; }

        public bool IsVisited { get; set; }

        public List<T> Childs { get; set; }
    }
}