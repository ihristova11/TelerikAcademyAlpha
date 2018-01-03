
using Dealership.Common.Enums;

namespace Dealership.Models
{
    using Dealership.Contracts;
    using System;

    public class Motorcycle : Vehicle, IMotorcycle, IVehicle
    {
        private int wheels;
        private string category;

        public Motorcycle(string make, string model, decimal price, string category) : base(make, model, price, VehicleType.Motorcycle, (int)VehicleType.Motorcycle)
        {
            this.Category = category;
        }

        public string Category
        {
            get { return this.category; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Category must be between 3 and 10 characters long!");
                }
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentException("Category must be between 3 and 10 characters long!");
                }

                this.category = value;
            }
        }
    }
}
