using System.Collections.Generic;
using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Engine
{
    public class DataStore : IDataStore
    {
        private readonly IDictionary<string, ICompany> companies;
        private readonly IDictionary<string, IFurniture> furniture;

        public DataStore()
        {
            this.companies = new Dictionary<string, ICompany>();
            this.furniture = new Dictionary<string, IFurniture>();
        }
        
        public IDictionary<string, ICompany> Companies
        {
            get
            {
                return this.companies;
            }
        }
        
        public IDictionary<string, IFurniture> Furnitures
        {
            get
            {
                return this.furniture;
            }
        }

        public void AddCompany(ICompany company)
        {
            Guard.WhenArgument(company, company.GetType().Name).IsNull().Throw();
            this.Companies.Add(company.Name, company);
        }

        public void AddFurniture(IFurniture furniture)
        {
            Guard.WhenArgument(furniture, furniture.GetType().Name).IsNull().Throw();
            this.Furnitures.Add(furniture.Model, furniture);
        }
    }
}
