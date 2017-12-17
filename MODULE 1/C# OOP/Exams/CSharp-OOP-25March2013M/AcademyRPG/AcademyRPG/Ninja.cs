using System.Collections.Generic;
using System.Linq;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        public Ninja(string name, Point position, int owner) : base(name, position, owner)
        {
            base.HitPoints = 1;
            this.DefensePoints = int.MaxValue;
            this.AttackPoints = 0;
        }

        public int AttackPoints { get; private set; }
        public int DefensePoints { get; }
        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            WorldObject target = availableTargets
                .OrderByDescending(x => x.HitPoints)
                .FirstOrDefault(x => x.Owner != this.Owner && x.Owner != 0);

            return availableTargets.IndexOf(target);
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }

            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints = resource.Quantity * 2;
                return true;
            }

            return false;
        }
    }
}
