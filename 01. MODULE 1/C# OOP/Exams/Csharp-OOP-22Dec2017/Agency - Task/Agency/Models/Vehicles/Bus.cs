using Agency.Models.Vehicles;
using Agency.Models.Vehicles.Contracts;
using Agency.Models.Vehicles.Enums;

namespace Agency.Models
{
    public class Bus : Vehicle, IBus
    {
        private int passangerCapacity;

        public Bus(int passengerCapacity, decimal pricePerKilometer)
            : base(passengerCapacity, pricePerKilometer)
        {
            this.Type = VehicleType.Land;
        }

        public override int PassangerCapacity {
            get { return this.passangerCapacity; }
            set
            {
                Validator.ValidateInetegerValues(value, Constants.BusMinCapacity, 
                    Constants.BusMaxCapacity, Constants.InvalidBusCapacity);

                this.passangerCapacity = value;
            }
        }
    }
}
