using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        private readonly string name;
        private readonly string registrationNumber;
        private readonly ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            Guard.WhenArgument(name, "Company name").IsNull().Throw();
            Guard.WhenArgument(name.Length, "Company name length").IsLessThan(5).Throw();
            Guard.WhenArgument(name, "Registration number").IsNull().Throw();

            if (!Regex.IsMatch(registrationNumber, "[0-9]{10}"))
            {
                throw new ArgumentException("Registration number is not valid");
            }

            this.name = name;
            this.registrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name => this.name;

        public string RegistrationNumber => this.registrationNumber;

        public ICollection<IFurniture> Furnitures => this.furnitures;

        public void Add(IFurniture furniture)
        {
            Guard.WhenArgument(furniture, "Furniture to add").IsNull().Throw();

            this.furnitures.Add(furniture);
        }

        public string Catalog()
        {
            var strBuilder = new StringBuilder();
            var anyFurniture = this.furnitures.Any() ? this.furnitures.Count.ToString() : "no";
            var singleOrPlural = this.furnitures.Count != 1 ? "furnitures" : "furniture";

            strBuilder.AppendLine($"{this.name} - {this.registrationNumber} - {anyFurniture} {singleOrPlural}");
            foreach (var furniture in this.furnitures.OrderBy(x=>x.Price).ThenBy(x=>x.Model))
            {
                strBuilder.AppendLine(furniture.ToString().Trim());
            }

            return strBuilder.ToString().Trim();
        }

        public IFurniture Find(string model)
        {
            Guard.WhenArgument(model, "Model").IsNull().Throw();

            return this.furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());
        }

        public void Remove(IFurniture furniture)
        {
            Guard.WhenArgument(furniture, "Furniture to remove").IsNull().Throw();

            this.furnitures.Remove(furniture);
        }
    }
}
