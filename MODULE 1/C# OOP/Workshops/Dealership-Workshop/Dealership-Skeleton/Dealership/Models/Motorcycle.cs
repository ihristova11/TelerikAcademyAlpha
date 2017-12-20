using Dealership.Contracts;

namespace Dealership.Models
{
    public class Motorcycle : Vehicle, IMotorcycle
    {
        private readonly string category;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            //validation
            this.category = category;
        }

        public string Category { get { return this.category; } }
    }
}
