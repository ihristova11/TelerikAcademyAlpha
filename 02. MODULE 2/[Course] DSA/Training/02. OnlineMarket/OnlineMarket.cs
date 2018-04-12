using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.OnlineMarket
{
    public class Product : IComparable<Product>
    {
        public Product(string name, double price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

        public int CompareTo(Product other)
        {
            int result = this.Price.CompareTo(other.Price);
            if (result == 0)
            {
                result = this.Name.CompareTo(other.Name);
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Price);
        }
    }

    public class OnlineMarket
    {
        static void Main()
        {
            string line;
            Dictionary<string, SortedSet<Product>> typeToProduct = new Dictionary<string, SortedSet<Product>>();
            SortedSet<Product> productsByPrice = new SortedSet<Product>();
            StringBuilder output = new StringBuilder();

            while ((line = Console.ReadLine()) != "end")
            {
                var commandArgs = line.Split(' ').ToArray();
                string choice = commandArgs[0];

                switch (choice)
                {
                    case "add":
                        string name = commandArgs[1];
                        double price = double.Parse(commandArgs[2]);
                        string type = commandArgs[3];

                        Product product = new Product(name, price, type);
                        if (!typeToProduct.ContainsKey(type))
                        {
                            typeToProduct.Add(type, new SortedSet<Product>());
                        }
                        if (typeToProduct[type].Contains(product))
                        {
                            output.AppendFormat("Error: Product {0} already exists", product.Name);
                            output.AppendLine();
                        }
                        else
                        {
                            typeToProduct[type].Add(product);
                            productsByPrice.Add(product);
                            output.AppendFormat("Ok: Product {0} added successfully", product.Name);
                            output.AppendLine();
                        }


                        break;
                    case "filter":
                        if (commandArgs.Length == 4) // filter by type
                        {
                            string filterType = commandArgs[3];
                            if (typeToProduct.ContainsKey(filterType))
                            {
                                var productsToList = typeToProduct[filterType].Take(10);
                                output.AppendFormat("Ok: {0}", string.Join(", ", productsToList));
                                output.AppendLine();
                            }
                            else
                            {
                                output.AppendFormat("Error: Type {0} does not exists", filterType);
                                output.AppendLine();
                            }
                        }
                        else if (commandArgs.Length == 7) // filter by price from min to max
                        {
                            double min = double.Parse(commandArgs[4]);
                            double max = double.Parse(commandArgs[6]);
                            var productsFromTo = productsByPrice.Where(x => x.Price >= min && x.Price <= max).Take(10);

                            output.AppendFormat("Ok: {0}", string.Join(", ", productsFromTo));
                            output.AppendLine();
                        }
                        else if (commandArgs.Length == 5) // filter from/to
                        {
                            string way = commandArgs[3];
                            switch (way)
                            {
                                case "from":
                                    double priceFrom = double.Parse(commandArgs[4]);
                                    var productsFrom = productsByPrice.Where(x => x.Price >= priceFrom).Take(10);
                                    output.AppendFormat("Ok: {0}", string.Join(", ", productsFrom));
                                    output.AppendLine();
                                    break;
                                case "to":
                                    double priceTo = double.Parse(commandArgs[4]);
                                    var productsTo = productsByPrice.Where(x => x.Price <= priceTo).Take(10);
                                    output.AppendFormat("Ok: {0}", string.Join(", ", productsTo));
                                    output.AppendLine();
                                    break;
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(output);
        }
    }
}