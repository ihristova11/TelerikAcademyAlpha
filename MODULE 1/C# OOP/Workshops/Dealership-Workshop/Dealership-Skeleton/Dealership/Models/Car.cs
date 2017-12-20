using Dealership.Contracts;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        public Car(string make, string model, decimal price, int seats)
            : base(make, model, price)
        {
        }

        public int Seats { get; }
    }
}
