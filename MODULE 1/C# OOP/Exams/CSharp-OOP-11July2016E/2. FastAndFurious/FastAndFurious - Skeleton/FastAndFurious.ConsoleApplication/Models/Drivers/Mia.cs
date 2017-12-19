using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class Mia : Driver
    {
        public Mia(string name, GenderType gender) : base(name, gender)
        {
            this.Name = "Mia";
            this.Gender = GenderType.Female;
        }
    }
}
