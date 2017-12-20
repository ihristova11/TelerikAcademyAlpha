using Dealership.Contracts;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck
    {
        public Truck(string make, string model, decimal price, int weightCapacity)
            : base(make, model, price)
        {
        }

        public int WeightCapacity { get; }
    }
}
