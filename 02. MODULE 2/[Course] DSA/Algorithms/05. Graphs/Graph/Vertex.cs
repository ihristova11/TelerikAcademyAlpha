using System;
using System.Collections.Generic;

namespace Graph
{
    public class Vertex<T>
    {
        public Vertex(T value)
        {
            this.Value = value;
            this.Neighbours = new Dictionary<string, Edge<T>>();
            //this.IsVisited = false;
        }

        public T Value { get; set; }

        public IDictionary<string, Edge<T>> Neighbours { get; set; }

        internal bool IsVisited { get; set; }

        internal void AddNeighbour(Edge<T> edge)
        {
            if (!this.Neighbours.ContainsKey(edge.Name))
            {
                this.Neighbours.Add(edge.Name, edge);
            }
            else
            {
                throw new ArgumentException("Already connected neighbour!");
            }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
