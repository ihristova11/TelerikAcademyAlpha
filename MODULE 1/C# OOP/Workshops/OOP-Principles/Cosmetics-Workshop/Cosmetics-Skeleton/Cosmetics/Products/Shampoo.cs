using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Text;

namespace Cosmetics.Products
{
    public class Shampoo : IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usageType)
        {
            Guard.WhenArgument(brand, "null or not").IsNull().Throw();
            Guard.WhenArgument(name, "null or not").IsNull().Throw();
            Guard.WhenArgument(price, "negative price").IsLessThan(0).Throw();
            Guard.WhenArgument(milliliters, "negative value").IsLessThan((uint)0).Throw();
            Guard.WhenArgument(name.Length, "invalid length").IsLessThan(3).Throw();
            Guard.WhenArgument(name.Length, "invalid length").IsGreaterThan(10).Throw();
            Guard.WhenArgument(brand.Length, "ivalid length").IsLessThan(2).IsGreaterThan(10).Throw();
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            this.Milliliters = milliliters;
            this.Usage = usageType;
            
        }

        public string Name { get; private set; }

        public string Brand { get; private set; }

        public decimal Price { get; private set; }

        public GenderType Gender { get; private set; }

        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"#{this.Name}");
            sb.AppendLine($" #Price: {this.Price}");
            sb.AppendLine($" #Gender: {this.Gender}");
            sb.AppendLine($" #Milliliters: {this.Milliliters}");
            sb.AppendLine($" #Usage: {this.Usage}");
            sb.AppendLine("===");

            return sb.ToString();
        }
    }
}
