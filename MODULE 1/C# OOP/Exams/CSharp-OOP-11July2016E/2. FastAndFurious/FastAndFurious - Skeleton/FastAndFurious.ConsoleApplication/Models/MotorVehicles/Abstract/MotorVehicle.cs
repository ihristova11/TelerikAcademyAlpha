using System;
using System.Collections.Generic;
using System.Linq;
using FastAndFurious.ConsoleApplication.Common.Constants;
using FastAndFurious.ConsoleApplication.Common.Exceptions;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract
{
    public abstract class MotorVehicle : IMotorVehicle, IWeightable, IValuable
    {

        public MotorVehicle(decimal price, int weight, int topSpeed, int acceleration)
        {
            this.Price = price;
            this.Weight = weight;
            this.TopSpeed = topSpeed;
            this.Acceleration = acceleration;
        }

        public decimal Price
        {
            get
            {
                return this.Price + this.TunningParts.Sum(x => x.Price);
            }
            protected set
            {
                
            }
        }
        public int Weight { get; protected set; }

        public int Acceleration { get; protected set; }

        public int TopSpeed { get; protected set; }

        public IEnumerable<ITunningPart> TunningParts { get; protected set; }
        public int Id { get; }

        public void AddTunning(ITunningPart part)
        {
            throw new NotImplementedException();
        }
        public TimeSpan Race(int trackLengthInMeters)
        {
            // Oohh boy, you shouldn't have missed the PHYSICS class in high school.
            throw new NotImplementedException();
        }
        public bool RemoveTunning(ITunningPart part)
        {
            throw new NotImplementedException();
        }
    }
}
