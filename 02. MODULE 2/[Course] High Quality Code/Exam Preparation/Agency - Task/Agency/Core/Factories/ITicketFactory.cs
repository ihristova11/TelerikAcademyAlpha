using Agency.Models.Contracts;

namespace Agency.Core.Factories
{
    public interface ITicketFactory
    {
        ITicket CreateTicket(IJourney journey, decimal administrativeCosts);
    }
}
