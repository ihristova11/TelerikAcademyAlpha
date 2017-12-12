using Cosmetics.Contracts;
using System.Collections.Generic;

namespace Cosmetics.Contracts
{
    public interface IShoppingCart
    {
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        bool ContainsProduct(IProduct product);
        decimal TotalPrice();
    }
}