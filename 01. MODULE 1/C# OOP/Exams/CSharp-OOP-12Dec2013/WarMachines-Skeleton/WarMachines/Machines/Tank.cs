using System;
using System.Collections.Generic;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank, IMachine
    {
        private const int InitialHealthPoints = 100;

        public Tank(string name, double attackpoints, double defensePoints) : base(name)
        {
            this.HealthPoints = InitialHealthPoints;
            this.AttackPoints = attackpoints;
            this.DefensePoints = defensePoints;
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
            else
            {
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            string baseString = base.ToString();

            var result = new StringBuilder(baseString);

            result.Append(string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF"));

            return result.ToString();
        }
    }
}
