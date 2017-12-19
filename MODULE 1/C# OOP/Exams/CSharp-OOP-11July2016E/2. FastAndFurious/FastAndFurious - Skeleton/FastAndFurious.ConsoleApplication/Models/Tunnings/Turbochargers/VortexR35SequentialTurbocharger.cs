using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers
{
    public class VortexR35SequentialTurbocharger : Turbocharger
    {
        public const decimal VortexR35SequentialTurbochargerPrice = 799;
        public const int VortexR35SequentialTurbochargerWeight = 3500;
        public const int VortexR35SequentialTurbochargerAcceleration = 15;
        public const int VortexR35SequentialTurbochargerTopSpeed = 60;
        public const TunningGradeType VortexR35SequentialTurbochargerTunningGradeType = TunningGradeType.HighGrade;
        public const TurbochargerType VortexR35SequentialTurbochargerTurbochargerType = TurbochargerType.TwinTurbo;

        public VortexR35SequentialTurbocharger(decimal price,
            int weight,
            int acceleration,
            int topSpeed,
            TunningGradeType tunningGrade,
            TurbochargerType turbochargerType)
            : base(VortexR35SequentialTurbochargerPrice,
                VortexR35SequentialTurbochargerWeight,
                VortexR35SequentialTurbochargerAcceleration,
                VortexR35SequentialTurbochargerTopSpeed,
                VortexR35SequentialTurbochargerTunningGradeType,
                VortexR35SequentialTurbochargerTurbochargerType)
        {
        }
    }
}
