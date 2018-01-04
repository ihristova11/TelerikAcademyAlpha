using Agency.Models.Vehicles.Contracts;
using Agency.Models.Vehicles.Enums;

namespace Agency.Models.Vehicles
{
    public class Vehicle : IVehicle
    {
        private int passangerCapacity;
        private decimal pricePerKilometer;

        public Vehicle(int passengerCapacity, decimal pricePerKilometer)
        {
            this.PassangerCapacity = passengerCapacity;
            this.PricePerKilometer = pricePerKilometer;
        }

        public virtual int PassangerCapacity
        {
            get { return this.passangerCapacity; }
            set
            {
                Validator.ValidateInetegerValues(value, Constants.VehicleMinCapacity,
                    Constants.VehicleMaxCapacity, Constants.InvalidVehicleCapacity);

                this.passangerCapacity = value;
            }
        }

        public decimal PricePerKilometer
        {
            get { return this.pricePerKilometer; }
            private set
            {
                Validator.ValidatePrice(value, Constants.MinPrice,
                    Constants.MaxPrice, Constants.InvalidPricePerKilometer);

                this.pricePerKilometer = value;
            }
        }

        public VehicleType Type { get; protected set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} ----\nPassenger capacity: {this.PassangerCapacity}\nPrice per kilometer: {this.PricePerKilometer}\nVehicle type: {this.Type}";
        }
    }
}
