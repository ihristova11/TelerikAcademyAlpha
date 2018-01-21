namespace Graph
{
    public class Edge<T>
    {
        public Edge(string name, Vertex<T> neighbour, decimal weight)
        {
            this.Name = name;
            this.Neighbour = neighbour;
            this.Weight = weight;
        }

        public string Name { get; set; }

        public Vertex<T> Neighbour { get; set; }

        public decimal Weight { get; set; }
    }
}
