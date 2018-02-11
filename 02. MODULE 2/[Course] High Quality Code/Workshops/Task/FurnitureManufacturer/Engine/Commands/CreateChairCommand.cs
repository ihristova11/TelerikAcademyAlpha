using System.Collections.Generic;
using FurnitureManufacturer.Interfaces.Engine;
using ICommand = FurnitureManufacturer.Engine.Commands.Contracts.ICommand;

namespace FurnitureManufacturer.Engine.Commands
{
    public class CreateChairCommand : ICommand
    {
        private readonly IDataStore dataStore;
        private readonly IFurnitureFactory furnitureFactory;

        public CreateChairCommand(IDataStore dataStore, IFurnitureFactory furnitureFactory)
        {
            this.dataStore = dataStore;
            this.furnitureFactory = furnitureFactory;
        }

        public string Execute(IList<string> parameters)
        {
            var model = parameters[0];
            var material = parameters[1];
            var price = decimal.Parse(parameters[2]);
            var height = decimal.Parse(parameters[3]);
            var legs = int.Parse(parameters[4]);

            if (this.dataStore.Furnitures.ContainsKey(model))
            {
                return string.Format(EngineConstants.FurnitureExistsErrorMessage, model);
            }

            var chair = this.furnitureFactory.CreateChair(model, material, price, height, legs);

            this.dataStore.Furnitures.Add(model, chair);
            return string.Format(EngineConstants.ChairCreatedSuccessMessage, model);
        }
    }
}
