using System;
using System.Collections.Generic;
using System.Linq;
using FastAndFurious.ConsoleApplication.Common.Constants;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.Drivers.Abstract
{
    public abstract class Driver : IDriver
    {
        private readonly int id;
        private string name;
        private GenderType gender;

        public Driver(string name, GenderType gender)
        {
            this.Name = name;
            this.Gender = gender;
            this.id = DataGenerator.GenerateId();
            this.Vehicles = new List<IMotorVehicle>();
        }

        public IMotorVehicle ActiveVehicle { get; protected set; }


        public GenderType Gender
        {
            get { return this.gender; }
            protected set { this.gender = value; }
        }

        public int Id
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }

        public IEnumerable<IMotorVehicle> Vehicles { get; protected set; }

        public void AddVehicle(IMotorVehicle vehicle)
        {
            throw new NotImplementedException();
        }
        public bool RemoveVehicle(IMotorVehicle vehicle)
        {
            throw new NotImplementedException();
        }
        public void SetActiveVehicle(IMotorVehicle vehicle)
        {
            this.ActiveVehicle = vehicle;
        }
    }
}
