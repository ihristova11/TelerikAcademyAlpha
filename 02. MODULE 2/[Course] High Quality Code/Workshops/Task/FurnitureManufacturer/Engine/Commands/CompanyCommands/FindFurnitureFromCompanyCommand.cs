using System.Collections.Generic;
using FurnitureManufacturer.Engine.Commands.Contracts;

namespace FurnitureManufacturer.Engine.Commands.CompanyCommands
{
    public class FindFurnitureFromCompanyCommand : ICommand
    {
        private readonly IDataStore dataStore;

        public FindFurnitureFromCompanyCommand(IDataStore dataStore)
        {
            this.dataStore = dataStore;
        }
        
        public string Execute(IList<string> parameters)
        {
            var companyName = parameters[0];
            var furnitureName = parameters[1];

            if (!this.dataStore.Companies.ContainsKey(companyName))
            {
                return string.Format(EngineConstants.CompanyNotFoundErrorMessage, companyName);
            }

            var company = this.dataStore.Companies[companyName];
            var furniture = company.Find(furnitureName);
            if (furniture == null)
            {
                return string.Format(EngineConstants.FurnitureNotFoundErrorMessage, furnitureName);
            }

            return furniture.ToString();
        }
    }
}
