using Agency.Models.Contracts;
using Agency.Models.Vehicles.Contracts;

namespace Agency.Core.Contracts
{
    public interface IJourneyFactory
    {
        IJourney CreateJourney(string startingLocation, string destination, int distance, IVehicle vehicle);
    }
}
