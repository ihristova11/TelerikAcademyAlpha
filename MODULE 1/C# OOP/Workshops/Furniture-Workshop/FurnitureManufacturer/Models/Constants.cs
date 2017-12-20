using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace FurnitureManufacturer.Models
{
    public class Constants
    {
        //number constants
        public const decimal ConvertedChairHeight = 0.1m;
        public const int MinNameLength = 5;
        public const int RegistrationNumberLength = 10;

        //messages
        public const string ValidateHeight = "Height must be positive number!";
        public const string ValidateNumber = "Registration number is not valid";
        public const string InvalidName = "Invalid name!";
        public const string InvalidLength = "Length must be positive!";
        public const string InvalidWidth = "Width must be positive!";
        public const string InvalidPrice = "Price must be positive!";
        public const string InvalidHeight = "Height must be positive!";

        //patterns
        public static string NumberPattern = "[0 - 9]{10}";

        //materialTypes
        public const string Wooden = "wooden";
        public const string Leather = "leather";
        public const string Plastic = "plastic";
        public const string InvalidMaterialName = "Invalid material name: {0}";

    }
}
