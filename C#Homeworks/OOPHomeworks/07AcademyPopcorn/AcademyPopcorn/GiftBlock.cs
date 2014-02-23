﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class GiftBlock:Block
    {
        public GiftBlock(MatrixCoords topLeft) : base(topLeft)
        {
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;

        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> list = new List<GameObject>();
            if (this.IsDestroyed)
            {
                list.Add(new Gift(this.topLeft));
            }
            return list;
        }
      
    }
}
