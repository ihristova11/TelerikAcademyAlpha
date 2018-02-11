using System.Collections.Generic;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Engine
{
    public class DataStore : IDataStore
    {
        private readonly IDictionary<string, ICompany> companies;
        private readonly  IDictionary<string, IFurniture> furnitures;

        public DataStore()
        {
            this.furnitures = new Dictionary<string, IFurniture>();
            this.companies = new Dictionary<string, ICompany>();
        }

        public IDictionary<string, ICompany> Companies => new Dictionary<string, ICompany>(companies);
        public IDictionary<string, IFurniture> Furnitures => new Dictionary<string, IFurniture>(furnitures);

        public void AddCompany(ICompany company)
        {
            // validations
            this.Companies.Add(company.Name, company);
        }

        public void AddFurniture(IFurniture furniture)
        {
            // validations
            this.Furnitures.Add(furniture.Model, furniture);
        }
    }
}
