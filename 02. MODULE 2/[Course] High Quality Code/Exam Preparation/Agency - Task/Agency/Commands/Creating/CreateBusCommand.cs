using System;
using System.Collections.Generic;
using Agency.Commands.Contracts;
using Agency.Core.Contracts;
using Agency.Core.Factories;

namespace Agency.Commands.Creating
{
    public class CreateBusCommand : ICommand
    {
        private readonly IVehicleFactory factory;
        private readonly IDataStore dataStore;


        public CreateBusCommand(IVehicleFactory factory, IDataStore dataStore)
        {
            this.factory = factory;
            this.dataStore = dataStore;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateBus command parameters.");
            }

            var bus = this.factory.CreateBus(passengerCapacity, pricePerKilometer);
            this.dataStore.Vehicles.Add(bus);

            return $"Vehicle with ID {this.dataStore.Vehicles.Count - 1} was created.";
        }

    }
}
