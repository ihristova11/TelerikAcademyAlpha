using System.Collections.Generic;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Engine
{
    public interface IDataStore
    {
        IDictionary<string, ICompany> Companies { get; }
        IDictionary<string, IFurniture> Furnitures { get; }

        void AddCompany(ICompany company);
        void AddFurniture(IFurniture furniture);
    }
}