using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class DominicRendeto : Driver
    {
        public DominicRendeto(string name, GenderType gender) : base(name, gender)
        {
            this.Name = "Dominic Rendeto";
            this.Gender = GenderType.Male;
        }
    }
}
