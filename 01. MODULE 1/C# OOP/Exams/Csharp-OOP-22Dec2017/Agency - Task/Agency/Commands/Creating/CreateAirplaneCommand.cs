using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Commands.Contracts;
using Agency.Commands.Creating;
using Agency.Core.Contracts;

namespace Traveller.Commands.Creating
{
    // TODO
    public class CreateAirplaneCommand :  ICommand
    {
        private readonly IAgencyFactory factory;
        private readonly IEngine engine;

        public CreateAirplaneCommand(IAgencyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            bool hasFreeFood;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                hasFreeFood = bool.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateAirplane command parameters.");
            }

            var airplane = this.factory.CreateAirplane(passengerCapacity, pricePerKilometer, hasFreeFood);
            this.engine.Vehicles.Add(airplane);

            return $"Vehicle with ID {engine.Vehicles.Count - 1} was created.";
        }
    }
}
