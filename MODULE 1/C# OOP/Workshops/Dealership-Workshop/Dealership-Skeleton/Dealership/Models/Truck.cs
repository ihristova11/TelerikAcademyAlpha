using Dealership.Common.Enums;

namespace Dealership.Models
{
    using Dealership.Contracts;
    using System;

    public class Truck : Vehicle, ITruck, IVehicle
    {
        private int wheels;
        private int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity) : base(make, model, price, VehicleType.Truck, (int)VehicleType.Truck)
        {
            this.WeightCapacity = weightCapacity;
        }

        public int WeightCapacity
        {
            get { return this.weightCapacity; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Weight capacity must be between 1 and 100!");
                }
                this.weightCapacity = value;
            }
        }
    }
}
