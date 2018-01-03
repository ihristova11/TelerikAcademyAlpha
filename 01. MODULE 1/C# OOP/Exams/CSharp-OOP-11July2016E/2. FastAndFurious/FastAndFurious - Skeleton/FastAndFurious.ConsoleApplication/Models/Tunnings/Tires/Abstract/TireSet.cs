using System;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Tires.Abstract
{
    public abstract class TiresSet : ITunningPart, ITireSet, IAccelerateable, ITopSpeed, IWeightable, IValuable
    {
        public TiresSet(decimal price, int weight,
            int acceleration, int topSpeed, TunningGradeType tunningGrade,
            TireType tireType)
        {
            this.Price = price;
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = topSpeed;
            this.GradeType = tunningGrade;
            this.TireType = tireType;
        }

        public int Acceleration { get; protected set; }


        public TunningGradeType GradeType { get; protected set; }

        public int Id { get; }

        public decimal Price { get; protected set; }

        public TireType TireType { get; protected set; }

        public int TopSpeed { get; protected set; }

        public int Weight { get; protected set; }
    }
}
