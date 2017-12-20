using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.SqlServer.Server;

namespace FurnitureManufacturer.Models
{
    public class Validator
    {
        public static void ValidateName(string input, int minLen, string msg)
        {
            if (input.Length < minLen || string.IsNullOrEmpty(input))
            {
                throw new ArgumentException(msg);
            }
        }

        public static void ValidateHeight(decimal height, string msg)
        {
            if (height < 0)
            {
                throw new ArgumentException(msg);
            }
        }

        public static void ValidateNumber(string input, string msg)
        {
            if (new Regex(Constants.NumberPattern).IsMatch(input))
            {
                throw new ArgumentException(msg);
            }
        }

        public static void ValidateDimension(decimal input, string msg)
        {
            if (input < 0)
            {
                throw new ArgumentException(msg);
            }
        }

        public static void ValidateIfNull(string input, string msg)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException();
            }
        }

        public static MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Constants.Wooden:
                    return MaterialType.Wooden;
                case Constants.Leather:
                    return MaterialType.Leather;
                case Constants.Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(Constants.InvalidMaterialName, material));
            }
        }
    }
}
