using FurnitureManufacturer.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer.Models
{
    // Finish the class
    public class Company : ICompany
    {
        private readonly string name;
        private readonly string registrationNumber;
        private readonly ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            Validator.ValidateName(name, Constants.MinNameLength, Constants.InvalidName);
            Validator.ValidateNumber(registrationNumber, Constants.ValidateNumber);

            this.name = name;
            this.registrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name => this.name;
        public string RegistrationNumber => this.registrationNumber;

        public ICollection<IFurniture> Furnitures => this.furnitures;

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
        }

        public string Catalog()
        {
            var strBuilder = new StringBuilder();
            var ordered = this.Furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model);
            
            strBuilder.AppendLine($"{this.Name} - {this.RegistrationNumber} - {(this.Furnitures.Count > 0 ? this.Furnitures.Count.ToString() + (this.Furnitures.Count == 1 ? " furniture" : " furnitures") : "no furnitures")}");

            if (ordered.Count() > 0)
            {
                foreach (var furniture in ordered)
                {
                    strBuilder.AppendLine(furniture.ToString());
                }
            }
            return strBuilder.ToString().Trim();
        }

        public IFurniture Find(string model)
        {
            var item = this.Furnitures.FirstOrDefault(x => x.Model == model);
            return item;
        }

        public void Remove(IFurniture furniture)
        {
            if (this.Furnitures.Contains(furniture))
            {
                this.Furnitures.Remove(furniture);
            }
        }
    }
}
