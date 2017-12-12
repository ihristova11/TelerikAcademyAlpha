using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System;

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
        }

        public string Name => throw new NotImplementedException();

        public string Brand => throw new NotImplementedException();

        public decimal Price => throw new NotImplementedException();

        public GenderType Gender => throw new NotImplementedException();

        public uint Milliliters => throw new NotImplementedException();

        public UsageType Usage => throw new NotImplementedException();

        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}
