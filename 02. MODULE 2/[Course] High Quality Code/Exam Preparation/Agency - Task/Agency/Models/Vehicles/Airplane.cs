using System;
using Agency.Models.Vehicles.Contracts;
using Agency.Models.Vehicles.Enums;

namespace Agency.Models.Vehicles
{
    public class Airplane : Vehicle, IAirplane
    {
        private readonly bool hasFreeFood;

        public Airplane(int passengerCapacity, decimal pricePerKilometer, bool hasFreeFood)
            : base(passengerCapacity, pricePerKilometer)
        {
            this.hasFreeFood = hasFreeFood;
            this.Type = VehicleType.Air;
        }

        public bool HasFreeFood { get { return this.hasFreeFood; } }

        public override string ToString()
        {
            return base.ToString() + $"\nHas free food: {this.HasFreeFood}";
        }
    }
}
