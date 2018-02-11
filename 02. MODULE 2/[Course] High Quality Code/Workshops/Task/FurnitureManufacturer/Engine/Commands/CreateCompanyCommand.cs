using System.Collections.Generic;
using FurnitureManufacturer.Interfaces.Engine;
using ICommand = FurnitureManufacturer.Engine.Commands.Contracts.ICommand;

namespace FurnitureManufacturer.Engine.Commands
{
    public class CreateCompanyCommand : ICommand
    {
        private readonly IDataStore dataStore;
        private readonly ICompanyFactory companyFactory;

        public CreateCompanyCommand(IDataStore dataStore, ICompanyFactory companyFactory)
        {
            this.dataStore = dataStore;
            this.companyFactory = companyFactory;
        }

        public string Execute(IList<string> parameters)
        {
            var companyName = parameters[0];
            var registrationNumber = parameters[1];
            if (this.dataStore.Companies.ContainsKey(companyName))
            {
                return string.Format(EngineConstants.CompanyExistsErrorMessage, companyName);
            }

            var company = this.companyFactory.CreateCompany(companyName, registrationNumber);   this.dataStore.Companies.Add(companyName, company);
            return string.Format(EngineConstants.CompanyCreatedSuccessMessage, companyName);
        }
    }
}
