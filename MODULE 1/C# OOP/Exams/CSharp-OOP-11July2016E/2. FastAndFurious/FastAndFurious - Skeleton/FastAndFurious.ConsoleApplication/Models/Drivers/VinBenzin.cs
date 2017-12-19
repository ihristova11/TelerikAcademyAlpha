using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class VinBenzin :Driver
    {
        public VinBenzin(string name, GenderType gender) : base(name, gender)
        {
            this.Name = "Vin Benzin";
            this.Gender = GenderType.Male;
        }
    }
}
