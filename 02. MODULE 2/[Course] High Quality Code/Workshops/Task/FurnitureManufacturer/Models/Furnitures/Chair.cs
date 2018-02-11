using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Chair : Furniture, IFurniture, IChair
    {
        private readonly int numberOfLegs;

        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs) 
            : base(model, materialType, price, height)
        {
            this.numberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs => this.numberOfLegs;

        protected override string AdditionalInfo()
        {
            return $", Legs: {this.NumberOfLegs}";
        }
    }
}
