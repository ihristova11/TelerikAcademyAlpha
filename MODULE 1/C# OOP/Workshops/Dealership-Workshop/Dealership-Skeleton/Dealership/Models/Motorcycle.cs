using Dealership.Contracts;

namespace Dealership.Models
{
    public class Motorcycle : Vehicle, IMotorcycle
    {
        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
        }

        public string Category { get; }
    }
}
