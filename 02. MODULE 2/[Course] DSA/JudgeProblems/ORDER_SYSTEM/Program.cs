using System;

namespace ORDER_SYSTEM
{
    public class Program
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine()); // get lines 

            while (n != 0)
            {
                var commandParameters = Console.ReadLine().Split(';');

                if (commandParameters[0].StartsWith("AddOrder"))
                {
                    var name = commandParameters[1];
                    var price = decimal.Parse(commandParameters[2]);
                    var consumer = commandParameters[3];
                }
                else if (commandParameters[0].StartsWith("DeleteOrders"))
                {
                    var consumer = commandParameters[1];
                }
                else if (commandParameters[0].StartsWith("FindOrdersByPriceRange"))
                {

                }
                else (commandParameters[0].StartsWith("FindOrdersByConsumer"))
                {
                }
            }
        }
    }

    public class Order
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Consumer { get; set; }

        public override string ToString()
        {
            return string.Format("{" + this.Name + ";" + this.Consumer + ";" + "{0:f2}", this.Price + "}");
        }
    }
}
