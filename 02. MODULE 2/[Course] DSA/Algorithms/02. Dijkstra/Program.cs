using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Node> graph = ReadGraph();
            DijkstraAlgorithm(graph, 1);
            PrintPathTo(graph, 1);
            PrintPathTo(graph, 2);
            PrintPathTo(graph, 3);
            PrintPathTo(graph, 4);
            PrintPathTo(graph, 5);
            PrintPathTo(graph, 6);
        }

        private static void DijkstraAlgorithm(Dictionary<int, Node> graph, int startNodeName)
        {
            Node startNode = graph[startNodeName];
            startNode.BestPath = 0;

            OrderedBag<Node> priorityQueue = new OrderedBag<Node>();
            priorityQueue.Add(startNode);

            while (priorityQueue.Count > 0)
            {
                Node node = priorityQueue.RemoveFirst();
                node.Visited = true;
                foreach (Edge edge in node.Childs)
                {
                    Node child = graph[edge.ToNode];
                    if (child.Visited)
                    {
                        continue;
                    }

                    int newPath = node.BestPath + edge.Weight;
                    if (newPath < child.BestPath)
                    {
                        priorityQueue.Remove(child);

                        child.BestPath = newPath;
                        child.Previous = node;

                        priorityQueue.Add(child);
                    }
                }
            }
        }

        public static void PrintPathTo(Dictionary<int, Node> graph, int startNodeName)
        {
            Node node = graph[startNodeName];
            Stack<Node> stack = new Stack<Node>();
            stack.Push(node);

            node = node.Previous;
            while (node != null)
            {
                stack.Push(node);
                node = node.Previous;
            }

            StringBuilder pathBuilder = new StringBuilder();
            while (stack.Count > 0)
            {
                pathBuilder.Append($"{stack.Pop().Name} ");
            }

            Console.WriteLine(pathBuilder);
        }

        private static Dictionary<int, Node> ReadGraph()
        {
            Dictionary<int, Node> graph = new Dictionary<int, Node>();

            graph.Add(1, new Node()
            {
                Name = 1,
                BestPath = int.MaxValue,
                Childs = new List<Edge>()
                {
                    new Edge() { ToNode = 3, Weight = 9 },
                    new Edge() { ToNode = 2, Weight = 7 },
                    new Edge() { ToNode = 6, Weight = 14 },
                }
            });

            graph.Add(2, new Node()
            {
                Name = 2,
                BestPath = int.MaxValue,
                Childs = new List<Edge>()
                {
                    new Edge() { ToNode = 3, Weight = 2 },
                    new Edge() { ToNode = 1, Weight = 7 },
                    new Edge() { ToNode = 4, Weight = 15 }
                }
            });

            graph.Add(3, new Node()
            {
                Name = 3,
                BestPath = int.MaxValue,
                Childs = new List<Edge>()
                {
                    new Edge() { ToNode = 2, Weight = 10 },
                    new Edge() { ToNode = 6, Weight = 2 },
                    new Edge() { ToNode = 1, Weight = 9 },
                    new Edge() { ToNode = 4, Weight = 11 },

                }
            });

            graph.Add(6, new Node()
            {
                Name = 6,
                BestPath = int.MaxValue,
                Childs = new List<Edge>()
                {
                    new Edge() { ToNode = 3, Weight = 2 },
                    new Edge() { ToNode = 5, Weight = 9 },
                    new Edge() { ToNode = 1, Weight = 14 },

                }
            });

            graph.Add(4, new Node()
            {
                Name = 4,
                BestPath = int.MaxValue,
                Childs = new List<Edge>()
                {
                    new Edge() { ToNode = 2, Weight = 15 },
                    new Edge() { ToNode = 3, Weight = 11 },
                    new Edge() { ToNode = 5, Weight = 6 }
                }
            });

            graph.Add(5, new Node()
            {
                Name = 5,
                BestPath = int.MaxValue,
                Childs = new List<Edge>()
                {
                    new Edge() { ToNode = 4, Weight = 6 },
                    new Edge() { ToNode = 6, Weight = 9 }
                }
            });

            return graph;
        }
    }

    public class Node : IComparable<Node>
    {
        public int Name { get; set; }

        public int BestPath { get; set; }

        public Node Previous { get; set; }

        public List<Edge> Childs { get; set; }

        public bool Visited { get; set; }

        public int CompareTo(Node node)
        {
            int compareToBestPath = this.BestPath.CompareTo(node.BestPath);
            return compareToBestPath == 0 ? this.Name.CompareTo(node.Name) : compareToBestPath;
        }
    }

    public class Edge
    {
        public int Weight { get; set; }

        public int ToNode { get; set; }
    }
}