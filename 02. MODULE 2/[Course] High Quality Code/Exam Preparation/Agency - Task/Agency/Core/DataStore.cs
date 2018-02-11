using System.Collections.Generic;
using Agency.Core.Contracts;
using Agency.Models.Contracts;
using Agency.Models.Vehicles.Contracts;
using Bytes2you.Validation;

namespace Agency.Core
{
    public class DataStore : IDataStore
    {
        private readonly IList<IVehicle> vehicles;
        private readonly IList<IJourney> journeys;
        private readonly IList<ITicket> tickets;
        
        public DataStore()
        {
            this.vehicles = new List<IVehicle>();
            this.journeys = new List<IJourney>();
            this.tickets = new List<ITicket>();
        }

        public IList<IVehicle> Vehicles => this.vehicles;

        public IList<IJourney> Journeys => this.journeys;

        public IList<ITicket> Tickets => this.tickets;

        public void AddVehicle(IVehicle vehicle)
        {
            Guard.WhenArgument(vehicle, "vehicle add").IsNull().Throw();
            this.vehicles.Add(vehicle);
        }

        public void AddJourney(IJourney journey)
        {
            Guard.WhenArgument(journey, "add journey").IsNull().Throw();
            this.journeys.Add(journey);
        }

        public void AddTicket(ITicket ticket)
        {
            Guard.WhenArgument(ticket, "add ticket").IsNull().Throw();
            this.tickets.Add(ticket);
        }
    }
}
