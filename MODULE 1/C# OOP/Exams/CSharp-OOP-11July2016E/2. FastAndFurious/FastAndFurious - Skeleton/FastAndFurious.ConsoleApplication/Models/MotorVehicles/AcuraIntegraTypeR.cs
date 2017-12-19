using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class AcuraIntegraTypeR : MotorVehicle
    {
        public AcuraIntegraTypeR(decimal price, int weight, int topSpeed, int acceleration) : base(price, weight, topSpeed, acceleration)
        {
        }
    }
}
