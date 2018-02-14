using System.Collections.Generic;
using ICommand = FurnitureManufacturer.Engine.Commands.Contracts.ICommand;

namespace FurnitureManufacturer.Engine.Commands.CompanyCommands
{
    public class AddFurnitureToCompanyCommand : ICommand
    {
        private readonly IDataStore dataStore;

        public AddFurnitureToCompanyCommand(IDataStore dataStore)
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
            company.Furnitures.Add(furniture);

            return string.Format(EngineConstants.FurnitureAddedSuccessMessage, furnitureName, companyName);
        }
    }
}
