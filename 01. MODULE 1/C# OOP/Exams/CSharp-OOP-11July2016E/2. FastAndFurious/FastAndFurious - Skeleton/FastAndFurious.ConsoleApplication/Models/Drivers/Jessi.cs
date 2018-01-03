using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class Jessi : Driver
    {
        public Jessi(string name, GenderType gender) : base(name, gender)
        {
            this.Name = "Jessi";
            this.Gender = GenderType.Female;
        }
    }
}
