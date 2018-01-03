using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    public class MagnaflowExhaust : Exhaust
    {
        public const decimal MagnaflowExhaustPrice = 379;
        public const int MagnaflowExhaustWeight = 128000;
        public const int MagnaflowAcceleration = 5;
        public const int MagnaflowExhaustTopSpeed = 25;
        public const TunningGradeType MagnaflowExhaustGradeType = TunningGradeType.LowGrade;
        public const ExhaustType MagnaflowExhaustExhaustType = ExhaustType.NickelChromePlated;



        public MagnaflowExhaust(decimal price, 
            int weight, 
            int acceleration, 
            int topSpeed, 
            TunningGradeType gradeType, 
            ExhaustType exhaustType) 
            : base(MagnaflowExhaustPrice,
                  MagnaflowExhaustWeight, 
                  MagnaflowAcceleration, 
                  MagnaflowExhaustTopSpeed, 
                  MagnaflowExhaustGradeType, 
                  MagnaflowExhaustExhaustType)
        {
        }
    }
}
