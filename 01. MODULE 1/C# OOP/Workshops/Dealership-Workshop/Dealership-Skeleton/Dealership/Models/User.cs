using System.Text;
using System.Text.RegularExpressions;

namespace Dealership.Models
{
    using Dealership.Common.Enums;
    using Dealership.Contracts;
    using System;
    using System.Collections.Generic;

    public class User : IUser
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private string usernamePattern = "^[A-Za-z0-9]+$";

        public User(string username, string firstName, string lastName, string password)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Vehicles = new List<IVehicle>();
        }

        public User(string username, string firstName, string lastName, string password, string role) : this(username, firstName, lastName, password)
        {
            this.Role = (Role) Enum.Parse(typeof(Role), role);
        }

        public string Username
        {
            get { return this.username; }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                Regex regex = new Regex(usernamePattern);
                if (!regex.IsMatch(value))
                {
                    throw new Exception("Username contains invalid symbols!");
                }
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException("Username must be between 2 and 20 characters long!");
                }

                this.username = value;
                //todo: add validation for regex pattern
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new Exception("Firstname must be between 2 and 20 characters long!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new Exception("Lastname must be between 2 and 20 characters long!");
                }

                this.lastName = value;
            }
        }

        public string Password
        {
            get { return this.password; }
            private set
            {
                if (value.Length < 5 || value.Length > 30)
                {
                    throw new Exception("Password must be between 5 and 30 characters long!");
                }
                this.password = value;
            }
        }
        public Role Role { get; }

        public IList<IVehicle> Vehicles { get; }

        public void AddVehicle(IVehicle vehicle)
        {
            if (this.Vehicles.Count > 4 && this.Role != Role.VIP)
            {
                throw new ArgumentException("You are not VIP and cannot add more than 5 vehicles!");
            }

            if (this.Role == Role.Admin)
            {
                throw new Exception("Admin cannot add vehicle");
            }
            
            this.Vehicles.Add(vehicle);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.Vehicles.Remove(vehicle);
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            commentToAdd.Author = this.Username;
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            commentToRemove.Author = this.Username;
            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public override string ToString()
        {
            return $"Username: {this.Username}, Fullname: {this.FirstName} {this.LastName}, Role: {this.Role}";
        }

        public string PrintVehicles()
        {
            StringBuilder sb = new StringBuilder();
            int count = 1;
            foreach (var vehicle in Vehicles)
            {
                sb.Append($"{count}. " + vehicle.ToString());
                count++;
            }
            return $"--USER {this.Username}--\n" + sb;
        }
    }
}
