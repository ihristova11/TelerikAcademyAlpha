using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers
{
    public class ZX8ParallelTwinTurbocharger : Turbocharger
    {
        public const decimal ZX8ParallelTwinTurbochargerPrice = 799;
        public const int ZX8ParallelTwinTurbochargerWeight = 3500;
        public const int ZX8ParallelTwinTurbochargerAcceleration = 15;
        public const int ZX8ParallelTwinTurbochargerTopSpeed = 60;
        public const TunningGradeType Zx8ParallelTwinTurbochargerTunningGradeType = TunningGradeType.HighGrade;
        public const TurbochargerType Zx8ParallelTwinTurbochargerType = TurbochargerType.TwinTurbo;

        public ZX8ParallelTwinTurbocharger(decimal price, 
            int weight, 
            int acceleration, 
            int topSpeed, 
            TunningGradeType tunningGrade, 
            TurbochargerType turbochargerType) 
            : base(ZX8ParallelTwinTurbochargerPrice, 
                  ZX8ParallelTwinTurbochargerWeight, 
                  ZX8ParallelTwinTurbochargerAcceleration, 
                  ZX8ParallelTwinTurbochargerTopSpeed, 
                  Zx8ParallelTwinTurbochargerTunningGradeType, 
                  Zx8ParallelTwinTurbochargerType)
        {
            
        }
    }
}
