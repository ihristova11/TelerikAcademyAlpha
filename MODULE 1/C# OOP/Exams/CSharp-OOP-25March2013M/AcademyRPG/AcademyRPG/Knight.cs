﻿using System.Collections.Generic;

namespace AcademyRPG
{
    public class Knight : Character, IFighter
    {
        public Knight(string name, Point position, int owner) : base(name, position, owner)
        {
            this.AttackPoints = 100;
            this.DefensePoints = 100;
            this.HitPoints = 100;
        }

        public int AttackPoints { get; }
        public int DefensePoints { get; }
        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}