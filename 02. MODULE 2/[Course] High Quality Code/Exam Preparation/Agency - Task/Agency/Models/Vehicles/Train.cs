using System.Threading;
using Agency.Models.Vehicles.Contracts;
using Agency.Models.Vehicles.Enums;

namespace Agency.Models.Vehicles
{
    public class Train : Vehicle, ITrain
    {
        private int carts;
        private int passangerCapacity;

        public Train(int passengerCapacity, decimal pricePerKilometer, int carts)
            : base(passengerCapacity, pricePerKilometer)
        {
            this.Carts = carts;
            this.Type = VehicleType.Land;
        }

        public override int PassangerCapacity
        {
            get { return this.passangerCapacity; }
            set
            {
                Validator.ValidateInetegerValues(value, Constants.TrainMinCapacity,
                    Constants.TrainMaxCapacity, Constants.InvalidTrainCapacity);

                this.passangerCapacity = value;
            }
        }

        public int Carts
        {
            get { return this.carts; }
            private set
            {
                Validator.ValidateInetegerValues(value, Constants.CartMinValue, 
                    Constants.CartMaxValue, Constants.InvalidCartsValue);

                this.carts = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCarts amount: {this.Carts}";
        }
    }
}
