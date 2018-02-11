using Agency.Models;
using Agency.Models.Contracts;

namespace Agency.Core.Factories
{
    public class TicketFactory : ITicketFactory
    {
        public ITicket CreateTicket(IJourney journey, decimal administrativeCosts)
        {
            return new Ticket(journey, administrativeCosts);
        }
    }
}
