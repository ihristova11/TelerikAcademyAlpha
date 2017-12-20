using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;

        private readonly decimal initialHeight;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs) : base(model, materialType, price, height, numberOfLegs)
        {
            this.initialHeight = this.Height;
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
            private set
            {
                if (isConverted)
                {
                    this.Height = Constants.ConvertedChairHeight;
                }
                else
                {
                    this.Height = this.initialHeight;
                }

                this.IsConverted = value;
            }
        }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
        }

        public override string ToString()
        {
            string state = isConverted ? "Converted": "Normal";
            return base.ToString() + $", State: {state}";
        }
    }
}
