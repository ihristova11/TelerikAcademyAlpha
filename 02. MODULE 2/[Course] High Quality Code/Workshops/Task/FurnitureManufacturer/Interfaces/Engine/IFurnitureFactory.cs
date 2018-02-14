namespace FurnitureManufacturer.Interfaces.Engine
{
    public interface IFurnitureFactory
    {
        IFurniture CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width);

        IFurniture CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs);        
    }
}
