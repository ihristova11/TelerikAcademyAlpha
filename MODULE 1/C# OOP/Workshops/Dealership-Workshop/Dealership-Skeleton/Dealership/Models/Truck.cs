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

        public override int Wheels
        {
            get { return Constants.TruckWheels; }
        }

        public override string ToString()
        {
            return base.ToString() + $"Weight capacity: {this.WeightCapacity}";
        }
    }
}
