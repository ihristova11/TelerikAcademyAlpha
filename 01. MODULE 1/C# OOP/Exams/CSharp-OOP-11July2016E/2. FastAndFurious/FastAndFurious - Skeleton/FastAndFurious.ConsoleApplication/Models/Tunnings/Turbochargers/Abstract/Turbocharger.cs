using System;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers.Abstract
{
    public abstract class Turbocharger : ITurbocharger, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable 
    {
        public Turbocharger(decimal price,
            int weight, int acceleration, int topSpeed,
            TunningGradeType tunningGrade, TurbochargerType turbochargerType)
        {
            this.Price = price;
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = topSpeed;
            this.GradeType = tunningGrade;
            this.TurbochargerType = turbochargerType;
        }

        public int Acceleration { get; protected set; }

        public TunningGradeType GradeType { get; protected set; }

        public int Id { get; private set; }

        public decimal Price { get; protected set; }

        public int TopSpeed { get; protected set; }

        public TurbochargerType TurbochargerType { get; protected set; }

        public int Weight { get; protected set; }
    }
}
