using Cosmetics.Cart;
using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Products;
using System;
using System.Collections.Generic;

namespace Cosmetics.Core.Engine
{
    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            Category category = new Category(name);
            return category;
        }

        public Shampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {            
            Shampoo shampoo = new Shampoo(name, brand, price, gender, milliliters, usage);
            return shampoo;
        }


        public Toothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            Toothpaste toothpaste = new Toothpaste(name, brand, price, gender, string.Join(", ",ingredients));
            return toothpaste;
        }

        public ShoppingCart CreateShoppingCart()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            return shoppingCart;
        }

    }
}
