using Autofac;
using FurnitureManufacturer.Interfaces.Engine;
using ICommand = FurnitureManufacturer.Engine.Commands.Contracts.ICommand;

namespace FurnitureManufacturer.Engine.Factories
{
    public class CommandFactory : ICommandFactory
    {
        private readonly IComponentContext container;

        public CommandFactory(IComponentContext container)
        {
            this.container = container;
        }

        public ICommand GetCommand(string commandName)
        {
            return this.container.ResolveNamed<ICommand>(commandName);
        }
    }
}
