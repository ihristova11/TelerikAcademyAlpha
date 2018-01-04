using Agency.Models.Vehicles.Enums;

namespace Agency.Models.Vehicles.Contracts
{
    public interface ITrain : IVehicle
    {
        int Carts { get; }
    }
}