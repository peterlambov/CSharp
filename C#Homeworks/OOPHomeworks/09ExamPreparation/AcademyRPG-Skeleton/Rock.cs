using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
  public  class Rock:StaticObject,IResource
    {


      public Rock( int hitPoints,Point position) //owner of a static object is always neutral  - 0 
          : base(position)
        {
            this.HitPoints = hitPoints;
        }

      

        public int Quantity
        {
            get { return this.HitPoints / 2; }
        }

        public ResourceType Type
        {
            get { return ResourceType.Stone; }
        }
    }
}
