using System;
using System.Collections.Generic;
using Agency.Commands.Contracts;
using Agency.Core.Contracts;

namespace Agency.Commands.Creating
{
    public class ListVehiclesCommand : ICommand
    {
        private readonly IDataStore dataStore;

        public ListVehiclesCommand(IDataStore dataStore)
        {
            this.dataStore = dataStore;
        }

        public string Execute(IList<string> parameters)
        {
            var vehicles = this.dataStore.Vehicles;

            if (vehicles.Count == 0)
            {
                return "There are no registered vehicles.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, vehicles);
        }
    }
}

