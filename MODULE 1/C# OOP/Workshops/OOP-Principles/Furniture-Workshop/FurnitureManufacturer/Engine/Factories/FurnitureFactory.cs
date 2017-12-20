using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Interfaces.Engine;
using FurnitureManufacturer.Models.Furnitures;

namespace FurnitureManufacturer.Engine.Factories
{
    public class FurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            return new Table(model, materialType, price, height, length, width);
        }

        public IFurniture CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            return new Chair(model, materialType, price, height, numberOfLegs);
        }

        public IFurniture CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            return new AdjustableChair(model, materialType, price, height, numberOfLegs);
        }

        public IFurniture CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            return new ConvertibleChair(model, materialType, price, height, numberOfLegs);
        }
    }
}
