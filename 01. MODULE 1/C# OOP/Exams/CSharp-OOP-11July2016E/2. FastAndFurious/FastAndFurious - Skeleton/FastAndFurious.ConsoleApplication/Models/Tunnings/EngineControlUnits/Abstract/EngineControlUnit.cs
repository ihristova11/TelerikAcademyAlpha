using System;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.EngineControlUnits.Abstract
{
    public abstract class EngineControlUnit : IEngineControlUnit, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
    {
        private EngineControlUnitType engineControlUnitType;

        public EngineControlUnit(
            decimal price,
            int weight,
            int acceleration,
            int topSpeed,
            TunningGradeType gradeType,
            EngineControlUnitType engineControlUnitType)
        {
            this.Price = price;
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = topSpeed;
            this.GradeType = gradeType;
            this.EngineControlUnitType = engineControlUnitType;
        }

        public int Acceleration { get; protected set; }

        public EngineControlUnitType EngineControlUnitType { get; protected set; }

        public TunningGradeType GradeType { get; protected set; }

        public int Id { get; }

        public decimal Price { get; protected set; }

        public int TopSpeed { get; protected set; }

        public int Weight { get; protected set; }
    }
}
