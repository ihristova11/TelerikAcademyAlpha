using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Text;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usageType) : base(name, brand, price, gender)
        {
            Guard.WhenArgument(milliliters, "negative value").IsLessThan((uint)0).Throw();

            this.Milliliters = milliliters;
            this.Usage = usageType;
        }
            
        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        public string Print()
        {
            return $"#{this.Name} {this.Brand}\n #Price: {this.Price}\n #Gender: {this.Gender} \n #Milliliters: {this.Milliliters}\n #Usage: {this.Usage}\n===";
        }
    }
}
