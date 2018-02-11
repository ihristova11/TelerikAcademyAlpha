using System;
using System.Collections.Generic;
using Agency.Commands.Contracts;
using Agency.Core.Contracts;
using Agency.Core.Factories;

namespace Agency.Commands.Creating
{
    public class CreateAirplaneCommand :  ICommand
    {
        private readonly IVehicleFactory factory;
        private readonly IDataStore dataStore;

        public CreateAirplaneCommand(IVehicleFactory factory, IDataStore dataStore)
        {
            this.factory = factory;
            this.dataStore = dataStore;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            bool hasFreeFood;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                hasFreeFood = bool.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateAirplane command parameters.");
            }

            var airplane = this.factory.CreateAirplane(passengerCapacity, pricePerKilometer, hasFreeFood);
            this.dataStore.Vehicles.Add(airplane);

            return $"Vehicle with ID {this.dataStore.Vehicles.Count - 1} was created.";
        }
    }
}
