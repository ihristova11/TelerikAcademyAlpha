using System.Collections.Generic;

namespace FurnitureManufacturer.Engine.Commands.Contracts
{
    public interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
