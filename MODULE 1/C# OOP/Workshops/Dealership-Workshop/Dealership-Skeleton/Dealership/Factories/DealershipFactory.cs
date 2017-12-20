using Dealership.Contracts;
using System;
using Dealership.Models;
using Dealership.Common.Enums;

namespace Dealership.Factories
{
    public class DealershipFactory : IDealershipFactory
    {
        public Car CreateCar(string make, string model, decimal price, int seats)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }

        public Motorcycle CreateMotorcycle(string make, string model, decimal price, string category)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }

        public Truck CreateTruck(string make, string model, decimal price, int weightCapacity)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }

        public IUser CreateUser(string username, string firstName, string lastName, string password, string role)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }

        public IComment CreateComment(string content)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }
    }
}
