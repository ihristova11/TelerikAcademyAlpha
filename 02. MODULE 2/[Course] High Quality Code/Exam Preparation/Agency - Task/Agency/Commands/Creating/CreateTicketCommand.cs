using System;
using System.Collections.Generic;
using Agency.Commands.Contracts;
using Agency.Core.Contracts;
using Agency.Core.Factories;
using Agency.Models.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateTicketCommand : ICommand
    {
        private readonly ITicketFactory factory;
        private readonly IDataStore dataStore;

        public CreateTicketCommand(ITicketFactory factory, IDataStore dataStore)
        {
            this.factory = factory;
            this.dataStore = dataStore;
        }

        public string Execute(IList<string> parameters)
        {
            IJourney journey;
            decimal administrativeCosts;

            try
            {
                journey = this.dataStore.Journeys[int.Parse(parameters[0])];
                administrativeCosts = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTicket command parameters.");
            }

            var ticket = this.factory.CreateTicket(journey, administrativeCosts);
            this.dataStore.Tickets.Add(ticket);

            return $"Ticket with ID {this.dataStore.Tickets.Count - 1} was created.";
        }
    }
}
