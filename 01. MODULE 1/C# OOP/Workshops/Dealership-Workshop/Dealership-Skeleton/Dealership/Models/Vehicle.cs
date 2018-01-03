using System.Security.Permissions;
using System.Text;

namespace Dealership.Models
{
    using Dealership.Common.Enums;
    using Dealership.Contracts;
    using System;
    using System.Collections.Generic;

    public abstract class Vehicle : IVehicle
    {
        private string make;
        private decimal price;
        private int wheels;
        private VehicleType type;
        private string model;

        public Vehicle(string make, string model, decimal price, VehicleType type, int wheels)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Type = type;
            this.Wheels = wheels;
            this.Comments = new List<IComment>();
        }

        public IList<IComment> Comments { get; }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (value < 0 || value > 1000000)
                {
                    throw new ArgumentException("Price must be between 0.0 and 1000000.0!");
                }

                this.price = value;
            }
        }

        public int Wheels { get; protected set;}
        public VehicleType Type { get; protected set; }

        public string Make
        {
            get { return this.make; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Make must be between 2 and 15 characters long!");
                }
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Make must be between 2 and 15 characters long!");
                }

                this.make = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException();
                }
                this.model = value;
            }
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            if (Comments.Count != 0)
            {
                sb.Append("  --COMMENTS--  \n");

                foreach (var comment in Comments)
                {
                    sb.AppendLine("  ----------  ");
                    sb.AppendLine(comment.ToString());
                    sb.AppendLine("  ----------  ");
                }
            }
            else
            {
                sb.AppendLine("  --NO COMMENTS--  ");
            }
            return $"{this.Type}:\nMake: {this.Make}\nModel: {this.Model}\nWheels: {this.Wheels}\nPrice: {this.Price}\n" + sb;
        }
        
    }
}
