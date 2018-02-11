using Agency.Commands.Contracts;

namespace Agency.Core.Factories
{
    public interface ICommandFactory
    {
        ICommand GetCommand(string commandName);
    }
}
