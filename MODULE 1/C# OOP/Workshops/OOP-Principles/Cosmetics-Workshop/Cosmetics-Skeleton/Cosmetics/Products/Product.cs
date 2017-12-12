namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using System;
    using Cosmetics.Common;
    using Bytes2you.Validation;
    using System.Text;

    public class Product : IProduct
    {
        public Product(string name, string brand, decimal price, GenderType gender)
        {
            Guard.WhenArgument(brand, "null or not").IsNull().Throw();
            Guard.WhenArgument(name, "null or not").IsNull().Throw();
            Guard.WhenArgument(name.Length, "name length").IsLessThan(3).IsGreaterThan(10).Throw();
            Guard.WhenArgument(brand.Length, "brand name length").IsLessThan(2).IsGreaterThan(10).Throw();

            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }
        public string Name { get; private set; }

        public string Brand { get; private set; }

        public decimal Price { get; private set; }

        public GenderType Gender { get; private set; }

        public virtual string Print()
        {
            return "";
        }
    }
}
