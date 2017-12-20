using System.Collections.Generic;
using System.Text;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Vehicle : IVehicle
    {
        private readonly string make;
        private readonly string model;
        private readonly decimal price;
        private readonly int wheels;
        private readonly IList<IComment> comments;

        public Vehicle(string make, string model, decimal price)
        {
            //TODO validations 

            this.make = make;
            this.model = model;
            this.price = price;
            this.comments = new List<IComment>().AsReadOnly();
        }

        public IList<IComment> Comments { get { return new List<IComment>(this.comments); } }

        public decimal Price {get { return this.price; }}

        public virtual int Wheels { get; }

        public VehicleType Type { get; }

        public string Make {get { return this.make; }}

        public string Model {get { return this.model; }}

        public override string ToString()
        {
            return $"{this.GetType().Name}\nMake: {this.Make}\nModel: {this.Model}\nWheels: {this.Wheels}\nPrice: {this.Price}";
        }

        public virtual string PrintComments()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Comments.Count > 0)
            {
                foreach (var comment in this.Comments)
                {
                    sb.AppendLine(comment.ToString());
                }

                return sb.ToString();
            }
            else
            {
                return "    --NO COMMENTS--";
            }
        }
    }
}
