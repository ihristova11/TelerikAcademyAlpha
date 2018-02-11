using System;
using System.Collections.Generic;
using Agency.Commands.Contracts;
using Agency.Core.Contracts;
using Agency.Models.Vehicles.Contracts;

namespace Agency.Commands.Creating
{
    public class CreateJourneyCommand : ICommand
    {
        private readonly IJourneyFactory factory;
        private readonly IDataStore dataStore;


        public CreateJourneyCommand(IJourneyFactory factory, IDataStore dataStore)
        {
            this.factory = factory;
            this.dataStore = dataStore;
        }

        public string Execute(IList<string> parameters)
        {
            string startLocation;
            string destination;
            int distance;
            IVehicle vehicle;

            try
            {
                startLocation = parameters[0];
                destination = parameters[1];
                distance = int.Parse(parameters[2]);
                vehicle = this.dataStore.Vehicles[int.Parse(parameters[3])];
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateJourney command parameters.");
            }

            var journey = this.factory.CreateJourney(startLocation, destination, distance, vehicle);
            this.dataStore.Journeys.Add(journey);

            return $"Journey with ID {this.dataStore.Journeys.Count - 1} was created.";
        }
    }
}
