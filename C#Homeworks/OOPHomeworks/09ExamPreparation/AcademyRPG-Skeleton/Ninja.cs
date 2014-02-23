using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
  public  class Ninja:Character,IFighter,IGatherer
    {
      private int attackPoints;
        public Ninja(string name, Point position, int owner) : base(name, position, owner)
        {
            this.HitPoints = 1;
        }

        public bool TryGather(IResource resource)
        {
           
                if (resource.Type == ResourceType.Lumber)
                {
                    this.attackPoints += resource.Quantity;
                    return true;
                }
                else   if (resource.Type == ResourceType.Stone)
                {
                    this.attackPoints += resource.Quantity * 2;
                    return true;
                }               
            
            return false;
        }

        public int AttackPoints
        {
            get { return attackPoints; }
            
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            //var sortedTargets = (List<WorldObject>)availableTargets.OrderByDescending(target => target.HitPoints);
            //List<WorldObject> temp = new List<WorldObject>();
            //foreach (var item in sortedTargets)
            //{
            //    temp.Add(item);
            //}
            //for (int i = 0; i < temp.Count; i++)
            //{
            //    if (temp[i].Owner != 0 && temp[i].Owner != this.Owner)
            //    {
            //        return i;
            //    }
            //}
            //return -1;
            int maxHitPoints = availableTargets.Max(t => t.HitPoints);
            WorldObject target = availableTargets.FirstOrDefault(t => t.Owner != 0 && t.Owner != this.Owner && t.HitPoints == maxHitPoints);
            return availableTargets.IndexOf(target);
        }
    }
}
