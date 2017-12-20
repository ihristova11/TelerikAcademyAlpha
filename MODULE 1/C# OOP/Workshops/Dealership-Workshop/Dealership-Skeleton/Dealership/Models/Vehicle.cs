using System.Collections.Generic;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Vehicle : IVehicle
    {
        private readonly string make;
        private readonly string model;
        private readonly decimal price;

        public Vehicle(string make, string model, decimal price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
        }

        public IList<IComment> Comments { get; }

        public decimal Price => this.price;

        public int Wheels { get; }

        public VehicleType Type { get; }

        public string Make => this.make;

        public string Model => this.model;
    }
}
