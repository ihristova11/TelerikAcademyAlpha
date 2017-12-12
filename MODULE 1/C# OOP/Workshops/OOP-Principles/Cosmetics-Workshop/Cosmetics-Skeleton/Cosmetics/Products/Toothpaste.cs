using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
            this.Ingredients = ingredients;
        }

        public string Ingredients { get; private set; }

        public string Name { get; private set; }

        public string Brand { get; private set; }

        public decimal Price { get; private set; }

        public GenderType Gender { get; private set; }

        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"#{this.Name}");
            sb.AppendLine($" #Price: {this.Price}");
            sb.AppendLine($" #Gender: {this.Gender}");
            sb.AppendLine($" #Ingredients: {this.Ingredients}");
            sb.AppendLine("===");

            return sb.ToString();
        }
    }
}