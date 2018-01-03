using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class Vince : Driver
    {
        public Vince(string name, GenderType gender) : base(name, gender)
        {
            this.Name = "Vince";
            this.Gender = GenderType.Male;
        }
    }
}
