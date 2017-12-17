using System.Collections.Generic;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        public Giant(string name, Point position, int owner) : base(name, position, 0)
        {
            this.AttackPoints = 150;
            this.DefensePoints = 80;
            this.HitPoints = 200;
        }

        public int AttackPoints { get; }
        public int DefensePoints { get; }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count;i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            bool isGathered = false;

            if (resource.Type == ResourceType.Stone && !isGathered)
            {
                this.HitPoints += 100;
                isGathered = true;
                return true;
            }

            return false;
        }
    }
}
