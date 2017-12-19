using System;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.Motors.Abstract
{
    public abstract class Motor : IMotor, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable 
    {
        public Motor(
            decimal price,
            int weight,
            int acceleration,
            int topSpeed,
            int horsepower,
            TunningGradeType gradeType,
            CylinderType cylinderType,
            MotorType engineType)
        {
            this.Price = price;
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = topSpeed;
            this.Horsepower = horsepower;
            this.GradeType = gradeType;
            this.CylinderType = cylinderType;
            this.EngineType = engineType;
        }

        public int Id { get; }

        public TunningGradeType GradeType { get; protected set; }

        public int Acceleration { get; protected set; }

        public int TopSpeed { get; protected set; }

        public int Weight { get; protected set; }

        public decimal Price { get; protected set; }

        public int Horsepower { get; protected set; }

        public MotorType EngineType { get; protected set; }

        public CylinderType CylinderType { get; protected set; }
    }
}
