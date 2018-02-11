using System.Collections.Generic;
using FurnitureManufacturer.Engine.Commands.Contracts;

namespace FurnitureManufacturer.Engine.Commands.CompanyCommands
{
    public class RemoveFurnitureFromCompanyCommand : ICommand
    {
        private readonly IDataStore dataStore;

        public RemoveFurnitureFromCompanyCommand(IDataStore dataStore)
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

            if (!this.dataStore.Furnitures.ContainsKey(furnitureName))
            {
                return string.Format(EngineConstants.FurnitureNotFoundErrorMessage, furnitureName);
            }

            var company = this.dataStore.Companies[companyName];
            var furniture = this.dataStore.Furnitures[furnitureName];
            company.Remove(furniture);

            return string.Format(EngineConstants.FurnitureRemovedSuccessMessage, furnitureName, companyName);
        }
    }
}
