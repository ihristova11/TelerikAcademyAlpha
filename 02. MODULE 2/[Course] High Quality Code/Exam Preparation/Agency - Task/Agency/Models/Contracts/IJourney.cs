using Agency.Models.Vehicles.Contracts;

namespace Agency.Models.Contracts
{
    public interface IJourney
    {
        string Destination { get; }

        int Distance { get; }

        string StartLocation { get;}

        IVehicle Vehicle { get; }

        decimal CalculateTravelCosts();
    }
}