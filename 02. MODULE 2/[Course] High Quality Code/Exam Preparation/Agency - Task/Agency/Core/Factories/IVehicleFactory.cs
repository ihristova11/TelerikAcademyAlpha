using Agency.Models.Vehicles.Contracts;

namespace Agency.Core.Factories
{
    public interface IVehicleFactory
    {
        IBus CreateBus(int passengerCapacity, decimal pricePerKilometer);

        ITrain CreateTrain(int passengerCapacity, decimal pricePerKilometer, int carts);

        IAirplane CreateAirplane(int passengerCapacity, decimal pricePerKilometer, bool hasFreeFood);
    }
}