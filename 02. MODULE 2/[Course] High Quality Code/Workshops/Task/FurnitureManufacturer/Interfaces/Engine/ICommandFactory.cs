namespace FurnitureManufacturer.Interfaces.Engine
{
    public interface ICommandFactory
    {
        FurnitureManufacturer.Engine.Commands.Contracts.ICommand GetCommand(string commandName);
    }
}
