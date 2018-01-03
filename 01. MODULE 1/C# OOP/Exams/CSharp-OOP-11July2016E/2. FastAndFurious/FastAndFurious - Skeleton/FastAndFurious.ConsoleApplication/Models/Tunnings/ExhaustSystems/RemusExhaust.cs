using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    public class RemusExhaust : Exhaust
    {
        public const decimal RemusExhaustPrice = 679;
        public const int RemusExhaustWeight = 11500;
        public const int RemusAcceleration = 8;
        public const int RemusExhaustTopSpeed = 32;
        public const TunningGradeType RemusExhaustGradeType = TunningGradeType.MidGrade;
        public const ExhaustType RemusExhaustExhaustType = ExhaustType.StainlessSteel;

        public RemusExhaust(decimal price,
            int weight, 
            int acceleration, 
            int topSpeed, 
            TunningGradeType gradeType, 
            ExhaustType exhaustType) 
            : base(RemusExhaustPrice, 
                  RemusExhaustWeight, 
                  RemusAcceleration, 
                  RemusExhaustTopSpeed, 
                  RemusExhaustGradeType, 
                  RemusExhaustExhaustType)
        {
        }
    }
}
