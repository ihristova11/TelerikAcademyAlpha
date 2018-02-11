using Agency.Models.Vehicles.Contracts;

namespace Agency.Models.Contracts
{
    public class Journey : IJourney
    {
        private string destination;
        private int distance;
        private string startLocation;

        public Journey(string startLocation, string destination, int distance, IVehicle vehicle)
        {
            this.StartLocation = startLocation;
            this.Destination = destination;
            this.Distance = distance;
            this.Vehicle = vehicle;
        }

        public string Destination
        {
            get { return this.destination; }
            private set
            {
                Validator.ValidateLength(value, Constants.DestinationAndLocationMinLength,
                    Constants.DestinationAndLocationMaxLength, Constants.InvalidDestinationLength);

                this.destination = value;
            }
        }

        public int Distance
        {
            get { return this.distance; }
            private set
            {
                Validator.ValidateInetegerValues(value, Constants.DistanceMinLength, 
                    Constants.DistanceMaxLength, Constants.InvalidDistanceLength);

                this.distance = value;
            }
        }

        public string StartLocation
        {
            get { return this.startLocation; }
            private set
            {
                Validator.ValidateLength(value, Constants.DestinationAndLocationMinLength,
                    Constants.DestinationAndLocationMaxLength, Constants.InvalidStartLocationLength);

                this.startLocation = value;
            }
        }

        public IVehicle Vehicle { get; }

        public decimal CalculateTravelCosts()
        {
            return this.Distance * this.Vehicle.PricePerKilometer;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} ----\nStart location: {this.StartLocation}\nDestination:" +
                   $" {this.Destination}\nDistance: {this.Distance}\nVehicle type: {this.Vehicle.Type}\nTravel costs: {this.CalculateTravelCosts()}";
        }
    }
}
