using Dealership.Contracts;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        private readonly int seats;

        public Car(string make, string model, decimal price, int seats)
            : base(make, model, price)
        {
            this.seats = seats;
        }

        public int Seats { get { return this.seats; } }

        public override int Wheels { get { return Constants.CarWheels; } }

        public override string ToString()
        {
            return base.ToString() + $"Seats: {this.Seats}";
        }
    }
}
