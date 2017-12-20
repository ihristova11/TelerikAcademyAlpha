using System;
using System.Collections.Generic;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class User : IUser
    {
        private readonly string username;
        private readonly string firstName;
        private readonly string lastName;
        private readonly string password;
        private readonly Role role;
        private IList<IVehicle> vehicles;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            Validator.ValidateUser(username, Constants.UsernamePattern, Constants.InvalidUsername);
            Validator.ValidateUser(password, Constants.PsswordPattern, Constants.InvalidPassword);

            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.role = (Role) Enum.Parse(typeof(Enum), role);
            this.vehicles = new List<IVehicle>().AsReadOnly();
        }

        public string Username { get { return this.username; } }

        public string FirstName { get { return this.firstName; } }

        public string LastName { get { return this.lastName; } }

        public string Password { get { return this.password; } }

        public Role Role { get { return this.role; } }

        public IList<IVehicle> Vehicles { get { return new List<IVehicle>(this.vehicles); } }

        public void AddVehicle(IVehicle vehicle)
        {
            this.Vehicles.Add(vehicle);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.Vehicles.Remove(vehicle);
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            //validations
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            //validations
            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public string PrintVehicles()
        {
            return $"Username: {this.Username}, FullName: {this.FirstName} {this.LastName}, Role: {this.Role}";
        }
    }
}
