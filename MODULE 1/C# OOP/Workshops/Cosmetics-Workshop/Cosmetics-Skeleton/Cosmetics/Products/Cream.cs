namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Cream : Product, ICreame
    {
        public Cream(string name, string brand, decimal price, GenderType gender, ScentType scent) : base(name, brand, price, gender)
        {
            this.Scent = scent;
        }

        public ScentType Scent { get; private set; }

        public override string Print()
        {
            return $"#{this.Name} {this.Brand}\n #Price: {this.Price}\n #Gender: {this.Gender} \n #Scent: {this.Scent}\n===";
        }
    }
}
