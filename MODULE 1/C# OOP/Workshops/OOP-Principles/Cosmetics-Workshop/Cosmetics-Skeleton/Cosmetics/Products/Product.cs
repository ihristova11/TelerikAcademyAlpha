namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using System;
    using Cosmetics.Common;

    public class Product : IProduct
    {
        public string Name { get; private set; }

        public string Brand { get; private set; }

        public decimal Price { get; private set; }

        public GenderType Gender { get; private set; }

        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}
