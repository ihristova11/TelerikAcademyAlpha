using System.Collections.Generic;
using Agency.Models.Contracts;
using Agency.Models.Vehicles.Contracts;

namespace Agency.Core.Contracts
{
    public interface IDataStore
    {
        IList<IVehicle> Vehicles { get; }

        IList<IJourney> Journeys { get; }

        IList<ITicket> Tickets { get; }

        void AddVehicle(IVehicle vehicle);

        void AddJourney(IJourney journey);

        void AddTicket(ITicket ticket);
    }
}