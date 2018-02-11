using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Table : Furniture, ITable
    {
        private readonly decimal length;
        private readonly decimal width;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width) 
            : base(model, materialType, price, height)
        {
            Guard.WhenArgument(length, "Length cannot be less than zero").IsLessThan(0).Throw();
            Guard.WhenArgument(width, "Width cannot be less than zero").IsLessThan(0).Throw();

            this.length = length;
            this.width = width;
        }

        public decimal Length => this.length;

        public decimal Width => this.width;

        public decimal Area => this.width * this.length;

        protected override string AdditionalInfo()
        {
            return $", Length: {this.Length}, Width: {this.Width}, Area: {this.Area}";
        }
    }
}
