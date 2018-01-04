namespace Agency.Models
{
    public class Constants
    {
        //error messages
        public const string InvalidBusCapacity = "A bus cannot have less than 10 passengers or more than 50 passengers.";
        public const string InvalidTrainCapacity = "A train cannot have less than 30 passengers or more than 150 passengers.";
        public const string InvalidVehicleCapacity = "A vehicle with less than 1 passengers or more than 800 passengers cannot exist!";
        public const string InvalidPricePerKilometer = "A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!";
        public const string InvalidStartLocationLength = "The StartingLocation's length cannot be less than 5 or more than 25 symbols long.";
        public const string InvalidDestinationLength = "The Destination's length cannot be less than 5 or more than 25 symbols long.";
        public const string InvalidDistanceLength = "The Distance cannot be less than 5 or more than 5000 kilometers.";
        public const string InvalidCartsValue = "A train cannot have less than 1 cart or more than 15 carts.";


        //capacity constants
        public const int TrainMinCapacity = 30;
        public const int TrainMaxCapacity = 150;

        public const int VehicleMinCapacity = 1;
        public const int VehicleMaxCapacity = 800;

        public const int BusMinCapacity = 10;
        public const int BusMaxCapacity = 50;

        //price constants
        public const decimal MinPrice = 0.10m;
        public const decimal MaxPrice = 2.50m;

        //length constants
        public const int DestinationAndLocationMinLength = 5;
        public const int DestinationAndLocationMaxLength = 25;

        public const int DistanceMinLength = 5;
        public const int DistanceMaxLength = 5000;

        public const int CartMinValue = 1;
        public const int CartMaxValue = 15;

    }
}
