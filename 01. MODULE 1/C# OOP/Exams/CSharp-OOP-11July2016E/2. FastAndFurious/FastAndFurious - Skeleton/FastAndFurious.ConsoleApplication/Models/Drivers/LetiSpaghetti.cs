using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class LetiSpaghetti : Driver
    {
        public LetiSpaghetti(string name, GenderType gender) : base(name, gender)
        {
            this.Name = "Leti Spaghetti";
            this.Gender = GenderType.Female;
        }
    }
}
