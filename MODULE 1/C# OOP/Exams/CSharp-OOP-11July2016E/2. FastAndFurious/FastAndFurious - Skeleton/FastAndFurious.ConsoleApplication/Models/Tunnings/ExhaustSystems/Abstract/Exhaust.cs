using System;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract
{
    public abstract class Exhaust : IExhaust, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable 
    {
        private readonly ExhaustType exhaustType;

        public Exhaust(
           decimal price,
           int weight,
           int acceleration,
           int topSpeed,
           TunningGradeType gradeType,
           ExhaustType exhaustType)
        {
            this.Price = price;
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = topSpeed;
            this.GradeType = gradeType;
            this.exhaustType = exhaustType;
        }

        public int Acceleration { get; protected set; }

        public ExhaustType ExhaustType { get; protected set; }

        public TunningGradeType GradeType { get; protected set; }

        public int Id { get; }

        public decimal Price { get; protected set; }

        public int TopSpeed { get; protected set; }

        public int Weight { get; protected set; }
    }
}
