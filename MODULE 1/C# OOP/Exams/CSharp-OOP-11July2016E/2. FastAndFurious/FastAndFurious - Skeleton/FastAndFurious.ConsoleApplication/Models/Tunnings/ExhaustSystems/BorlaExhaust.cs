using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
   public class BorlaExhaust : Exhaust
    {
        public const decimal BorlaExhaustPrice = 1299;
        public const int BorlaExhaustWeight = 14600;
        public const int BorlaAcceleration = 12;
        public const int BorlaExhaustTopSpeed = 40;
        public const TunningGradeType BorlaExhaustGradeType = TunningGradeType.HighGrade;
        public const ExhaustType BorlaExhaustExhaustType = ExhaustType.CeramicCoated;



        public BorlaExhaust(
            decimal price,
            int weight,
            int acceleration,
            int topSpeed,
            TunningGradeType gradeType,
            ExhaustType exhaustType)
            : base(
                BorlaExhaustPrice,
                BorlaExhaustWeight,
                BorlaAcceleration,
                BorlaExhaustTopSpeed,
                BorlaExhaustGradeType,
                BorlaExhaustExhaustType)
        {
        }
    }
}
