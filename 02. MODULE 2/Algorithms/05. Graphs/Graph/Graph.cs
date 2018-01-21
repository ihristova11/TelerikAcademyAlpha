using System;
using System.Collections.Generic;

namespace Graph
{
    public class Graph<T>
    {
        public Dictionary<T, Vertex<T>> Verteces { get; set; } // key = vertex value, value = vertex<t>

        // methods 

        // -------Add vertex methods

        public void AddVertex(T vertexValue)
        {
            if (!this.Verteces.ContainsKey(vertexValue))
            {
                var newVertex = new Vertex<T>(vertexValue);
                this.Verteces.Add(vertexValue, newVertex); // add new vertex in the dictionary
            }
            else
            {
                throw new ArgumentException("Graph already has this vertex!");
            }
        }

        public void AddVertex(Vertex<T> vertexToAdd)
        {
            if (!this.Verteces.ContainsKey(vertexToAdd.Value)) // if the vertex.value is in the dictionary
            {
                this.Verteces.Add(vertexToAdd.Value, vertexToAdd);
            }
            else
            {
                throw new ArgumentException("Graph already has this vertex!");
            }
        }

        // -----Add neighbour methods-----

        public void AddNeighbourToVertex(Vertex<T> vertex, Vertex<T> neighbourToAdd, 
            string edgeName, decimal weight = 1, bool isDoubleLinked = true)
        {
            if (this.Verteces.ContainsKey(vertex.Value))
            {
                if (!vertex.Neighbours.ContainsKey(edgeName))
                {
                    var newEdge = new Edge<T>(edgeName, neighbourToAdd, weight);
                    vertex.Neighbours.Add(edgeName, newEdge);

                    if (isDoubleLinked)
                    {
                        if (!neighbourToAdd.Neighbours.ContainsKey(edgeName))
                        {
                            var neighbourEdge = new Edge<T>(edgeName, vertex, weight);
                            neighbourToAdd.Neighbours.Add(edgeName, neighbourEdge);
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Vertex already has connection to this neighbour!");
                }
            }
            else
            {
                throw new ArgumentException("Vertex doesn't exist in the graph!");
            }
        }

        public void AddNeighbourToVertex(T vertexValue, T neighbourValue, string edgeName, 
            decimal weight = 1, bool isDoubleLinked = true)
        {
            if (this.Verteces.ContainsKey(vertexValue))
            {
                var vertexToAdd = this.Verteces[vertexValue];

                Vertex<T> neighbour;
                if (this.Verteces.ContainsKey(neighbourValue))
                {
                    neighbour = this.Verteces[neighbourValue];
                }
                else
                {
                    neighbour = new Vertex<T>(neighbourValue);
                    this.Verteces.Add(neighbourValue, neighbour);
                }

                var edge = new Edge<T>(edgeName, neighbour, weight);
                vertexToAdd.Neighbours.Add(edgeName, edge);

                if (isDoubleLinked)
                {
                    var neighbourEdge = new Edge<T>(edgeName, vertexToAdd, weight);
                    neighbour.Neighbours.Add(edgeName, neighbourEdge);
                }
            }
            else
            {
                throw new ArgumentException("Vertex does not exist in the graph!");
            }
        }

        // ----Traverse DFS----
        public void Traverse()
        {
            foreach (var vertex in this.Verteces.Values)
            {
                if (!vertex.IsVisited)
                {
                    var list = new List<Vertex<T>>();
                    this.DFS(vertex, list);
                }
            }
        }

        private void DFS(Vertex<T> vertex, List<Vertex<T>> verteces)
        {
            // if vertex is visited stop the recursion
            if (vertex.IsVisited) 
            {
                return;
            }

            // if vertex is not visited mark it as visited and add it to the list of vertices
            vertex.IsVisited = true;
            verteces.Add(vertex);

            // for each vertex neighbour in the list call DFS with it and add it to the list
            foreach (var vertexNeighbour in vertex.Neighbours)
            {
                this.DFS(vertexNeighbour.Value.Neighbour, verteces);
            }

            Console.WriteLine(string.Join(" => ", verteces));
            verteces.Remove(vertex);
        }
    }

    public class StartUp
    {
        static void Main()
        {
            var graph = new Graph<int>();
            Console.WriteLine("write number of vertexes");
            int numberOfVerteces = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfVerteces; i++)
            {
                graph.AddVertex(i);
            }

            Console.WriteLine("enter number of connections");
            int numberOfEdges = int.Parse(Console.ReadLine());

            for (int j = 0; j < numberOfEdges; j++)
            {
                var commandParameters = Console.ReadLine().Split();

                int vertexValue = int.Parse(commandParameters[0]);
                int vertexNeighbour = int.Parse(commandParameters[1]);

                var edge = commandParameters[2];
                decimal weight = 1;
                bool isDoubleLinked = true;

                if (commandParameters.Length == 4)
                {
                    weight = decimal.Parse(commandParameters[3]);
                }
                if (commandParameters.Length == 5)
                {
                    weight = decimal.Parse(commandParameters[3]);
                    isDoubleLinked = bool.Parse(commandParameters[4]);
                }
                graph.AddNeighbourToVertex(vertexValue, vertexNeighbour, edge, weight, isDoubleLinked);
            }

            graph.Traverse();
        }
    }
}
