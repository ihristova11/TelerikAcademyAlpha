using System.Collections.Generic;
using FurnitureManufacturer.Interfaces.Engine;
using ICommand = FurnitureManufacturer.Engine.Commands.Contracts.ICommand;

namespace FurnitureManufacturer.Engine.Commands
{
    public class CreateTableCommand : ICommand
    {
        private readonly IDataStore dataStore;
        private readonly IFurnitureFactory furnitureFactory;

        public CreateTableCommand(IDataStore dataStore, IFurnitureFactory furnitureFactory)
        {
            this.furnitureFactory = furnitureFactory;
            this.dataStore = dataStore;
        }

        public string Execute(IList<string> parameters)
        {
            var model = parameters[0];
            var material = parameters[1];
            var price = decimal.Parse(parameters[2]);
            var height = decimal.Parse(parameters[3]);
            var length = decimal.Parse(parameters[4]);
            var width = decimal.Parse(parameters[5]);

            if (this.dataStore.Furnitures.ContainsKey(model))
            {
                return string.Format(EngineConstants.FurnitureExistsErrorMessage, model);
            }

            var table = this.furnitureFactory.CreateTable(model, material, price, height, length, width);
            this.dataStore.Furnitures.Add(model, table);
            return string.Format(EngineConstants.TableCreatedSuccessMessage, model);
        }
    }
}
