using System.Collections.Generic;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine, IFighter, IMachine
    {
        private const int InitialHealthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode) : base(name)
        {
            this.HealthPoints = InitialHealthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.StealthMode = stealthMode;
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            string baseString = base.ToString();

            var result = new StringBuilder(baseString);

            result.Append(string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));

            return result.ToString();
        }
    }
}
