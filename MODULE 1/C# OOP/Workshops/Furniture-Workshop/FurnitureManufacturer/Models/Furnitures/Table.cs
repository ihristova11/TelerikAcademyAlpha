using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Table : Furniture, ITable
    {
        private readonly decimal tableLength;
        private readonly decimal tableWidth;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
            Validator.ValidateDimension(length, Constants.InvalidLength);
            Validator.ValidateDimension(width, Constants.InvalidWidth);
            tableLength = length;
            tableWidth = width;
        }

        public decimal Length => this.tableLength;

        public decimal Width => this.tableWidth;

        public decimal Area => this.Width * this.Length; 

        public override string ToString()
        {
            return base.ToString() + $", Length: {this.Length}, Width: {this.Width}, Area: {this.Area}";
        }
    }
}
