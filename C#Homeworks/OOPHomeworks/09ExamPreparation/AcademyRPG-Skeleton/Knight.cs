﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    class Knight:Character,IFighter
    {
        public Knight(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 100;
        }
        public int AttackPoints
        {
            get { return 100; }
        }
        public int DefensePoints
        {
            get { return 100; }
        }
        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0 && availableTargets[i].Owner != this.Owner )
                {
                    return i;
                }
            }

            return -1;
        }

        public new   void  GoTo(Point destination)
        {
            this.Position = destination;
        }
       
    }
}
