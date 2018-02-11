using System;
using System.Collections.Generic;
using Agency.Commands.Contracts;
using Agency.Core.Contracts;
using Agency.Core.Factories;

namespace Agency.Commands.Creating
{
    public class CreateTrainCommand : ICommand
    {
        private readonly IVehicleFactory factory;
        private readonly IDataStore dataStore;


        public CreateTrainCommand(IVehicleFactory factory, IDataStore dataStore)
        {
            this.factory = factory;
            this.dataStore = dataStore;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            int cartsCount;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                cartsCount = int.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTrain command parameters.");
            }

            var train = this.factory.CreateTrain(passengerCapacity, pricePerKilometer, cartsCount);
            this.dataStore.Vehicles.Add(train);

            return $"Vehicle with ID {this.dataStore.Vehicles.Count - 1} was created.";
        }
    }
}
