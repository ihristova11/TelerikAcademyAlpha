using Dealership.Contracts;
using Dealership.Models;

namespace Dealership.Factories
{
    public interface IDealershipFactory
    {
        IUser CreateUser(string username, string firstName, string lastName, string password, string role);

        IComment CreateComment(string content);

        Car CreateCar(string make, string model, decimal price, int seats);

        Motorcycle CreateMotorcycle(string make, string model, decimal price, string category);

        Truck CreateTruck(string make, string model, decimal price, int weightCapacity);
    }
}
