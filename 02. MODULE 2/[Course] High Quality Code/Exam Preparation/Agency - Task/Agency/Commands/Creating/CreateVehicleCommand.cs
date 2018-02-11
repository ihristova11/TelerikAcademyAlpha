using System;
using System.Collections.Generic;
using Agency.Commands.Contracts;
using Agency.Core.Contracts;

namespace Agency.Commands.Creating
{
    public abstract class CreateVehicleCommand : ICommand
    {
        private readonly IAgencyFactory factory;
        private readonly IEngine engine;

        protected CreateVehicleCommand(IAgencyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public abstract string Execute(IList<string> parameters);
    }
}