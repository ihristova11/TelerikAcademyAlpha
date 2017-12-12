using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System.Collections;
using System.Collections.Generic;

namespace Cosmetics.Products
{
    public class Toothpaste : IToothpaste
    {
        public Toothpaste(string name, string brand, decimal price, GenderType gender, string ingredients)
        {
            Guard.WhenArgument(price, "negative price").IsLessThan(0).Throw();
            Guard.WhenArgument(name.Length, "name length").IsLessThan(3).IsGreaterThan(10).Throw();
            Guard.WhenArgument(brand.Length, "brand name length").IsLessThan(2).IsGreaterThan(10).Throw();
            Guard.WhenArgument(ingredients, "null or not").IsNull().Throw();
        }

        public string Ingredients => throw new System.NotImplementedException();

        public string Name { get; }

        public string Brand { get; }

        public decimal Price => throw new System.NotImplementedException();

        public GenderType Gender => throw new System.NotImplementedException();

        public string Print()
        {
            throw new System.NotImplementedException();
        }
    }
}