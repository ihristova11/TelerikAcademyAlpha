using System.Collections.Generic;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class User : IUser
    {
        public string Username { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string Password { get; }

        public Role Role { get; }

        public IList<IVehicle> Vehicles { get; }

        public void AddVehicle(IVehicle vehicle)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            throw new System.NotImplementedException();
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            throw new System.NotImplementedException();
        }

        public string PrintVehicles()
        {
            throw new System.NotImplementedException();
        }
    }
}
