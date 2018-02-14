using System.Collections.Generic;
using FurnitureManufacturer.Engine.Commands.Contracts;

namespace FurnitureManufacturer.Engine.Commands.CompanyCommands
{
    public class ShowCompanyCatalogCommand : ICommand
    {
        private readonly IDataStore dataStore;

        public ShowCompanyCatalogCommand(IDataStore dataStore)
        {
            this.dataStore = dataStore;
        }

        public string Execute(IList<string> parameters)
        {
            var companyName = parameters[0];

            if (!this.dataStore.Companies.ContainsKey(companyName))
            {
                return string.Format(EngineConstants.CompanyNotFoundErrorMessage, companyName);
            }

            return this.dataStore.Companies[companyName].Catalog();
        }
    }
}
