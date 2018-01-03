using System.Linq;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    // Finish the class
    public class Furniture : IFurniture
    {
        private readonly string model;
        private readonly string material;
        private readonly decimal price;
        private decimal height;


        public Furniture(string model, string materialType, decimal price, decimal height)
        {
            Validator.ValidateDimension(price, Constants.InvalidPrice);
            Validator.ValidateIfNull(model, Constants.InvalidName);
            Validator.GetMaterialType(materialType);
            Validator.ValidateDimension(height, Constants.InvalidHeight);

            this.model = model;
            this.material = materialType;
            this.price = price;
            this.Height = height;
        }

        public string Model => this.model;

        public string Material => this.material;

        public decimal Price => this.price;

        public decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                this.height = value;
            }
        }

        public override string ToString()
        {
            string material = this.Material.First().ToString().ToUpper() + this.Material.Substring(1);

            return $"Type: {this.GetType().Name}, Model: {this.model}, Material: {material}, Price: {this.Price}, Height: {this.Height.ToString("0.00")}";
        }
    }
}
