using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste
    {
        public Toothpaste(string name, string brand, decimal price, GenderType gender, string ingredients) : base(name, brand, price, gender)
        {
            this.Ingredients = ingredients;
        }

        public string Ingredients { get; private set; }

        public override string Print()
        {
            return $"#{this.Name} {this.Brand}\n #Price: {this.Price}\n #Gender: {this.Gender} \n #Ingredients: {this.Ingredients}\n===";
        }
    }
}