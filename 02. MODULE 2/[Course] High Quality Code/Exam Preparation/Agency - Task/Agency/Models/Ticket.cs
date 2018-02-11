using Agency.Models.Contracts;

namespace Agency.Models
{
    public class Ticket : ITicket
    {
        public Ticket(IJourney journey, decimal administrativeCosts)
        {
            this.Journey = journey;
            this.AdministrativeCosts = administrativeCosts;
        }

        public decimal AdministrativeCosts { get; } // validation?

        public IJourney Journey { get; }

        public decimal CalculatePrice()
        {
            return this.AdministrativeCosts + this.Journey.CalculateTravelCosts();
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} ----\nDestination: {this.Journey.Destination}\nPrice: {this.CalculatePrice()}";
        }
    }
}
