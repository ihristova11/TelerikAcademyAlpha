using System;
using System.Collections.Generic;
using Agency.Commands.Contracts;
using Agency.Core.Contracts;

namespace Agency.Commands.Creating
{
    public class ListJourneysCommand : ICommand
    {
        private readonly IDataStore dataStore;

        public ListJourneysCommand(IDataStore dataStore)
        {
            this.dataStore = dataStore;
        }

        public string Execute(IList<string> parameters)
        {
            var journeys = this.dataStore.Journeys;

            if (journeys.Count == 0)
            {
                return "There are no registered journeys.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, journeys);
        }
    }
}
