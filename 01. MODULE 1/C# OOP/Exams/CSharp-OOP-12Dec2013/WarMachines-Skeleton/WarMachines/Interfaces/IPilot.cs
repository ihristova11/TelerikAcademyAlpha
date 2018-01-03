using System.Runtime.CompilerServices;

namespace WarMachines.Interfaces
{
    public interface IPilot
    {
        string Name { get; }

        void AddMachine(IMachine machine);

        string Report();
    }
}
