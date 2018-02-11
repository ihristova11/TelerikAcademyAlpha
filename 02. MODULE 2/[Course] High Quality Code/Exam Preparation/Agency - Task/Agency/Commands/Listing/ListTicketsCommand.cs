using System;
using System.Collections.Generic;
using Agency.Commands.Contracts;
using Agency.Core.Contracts;

namespace Agency.Commands.Creating
{
    public class ListTicketsCommand : ICommand
    {
        private readonly IDataStore dataStore;

        public ListTicketsCommand(IDataStore dataStore)
        {
            this.dataStore = dataStore;
        }

        public string Execute(IList<string> parameters)
        {
            var tickets = this.dataStore.Tickets;

            if (tickets.Count == 0)
            {
                return "There are no registered tickets.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, tickets);
        }
    }
}
