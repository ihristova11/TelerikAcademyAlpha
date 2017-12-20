using System.Runtime.InteropServices;

namespace Dealership.Models
{
    public class Constants
    {
        public const string UsernamePattern = "^[A-Za-z0-9]+$";
        public const string PsswordPattern = "^[A-Za-z0-9@*_-]+$";

        public const string InvalidUsername = "";
        public const string InvalidPassword = "";

        public const int TruckWheels = 8;
        public const int CarWheels = 4;
        public const int MotorcycleWheels = 2;
    }
}
