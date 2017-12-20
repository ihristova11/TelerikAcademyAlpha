using Dealership.Common.Enums;

namespace Dealership.Models
{
    using Dealership.Contracts;
    using System;

    public class Car : Vehicle, ICar, IVehicle
    {
        private int wheels;
        private int seats;
        private string make;

        public Car(string make, string model, decimal price, int seats) : base(make, model, price, VehicleType.Car, (int)VehicleType.Car)
        {
           this.Seats = seats;
        }

        public int Seats
        {
            get { return this.seats; }
            private set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("Seats must be between 1 and 10!");
                }
                this.seats = value;
            }
        }
    }
}
