﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
  public  class Gift:MovingObject
    {
      public Gift(MatrixCoords topLeft)
          : base(topLeft, new char[,] {{'g'}}, new MatrixCoords(1,0))
      {

      }

      public override bool CanCollideWith(string otherCollisionGroupString)
      {
          return otherCollisionGroupString == "racket";
      }

      public override void RespondToCollision(CollisionData collisionData)
      {
          this.IsDestroyed = true;
      }

      public override IEnumerable<GameObject> ProduceObjects()
      {
          List<GameObject> producedObjects = new List<GameObject>();
          if (this.IsDestroyed)
          {
              producedObjects.Add(new ShootingRacket(new MatrixCoords(this.topLeft.Row + 1, this.topLeft.Col), 6));
          }
          return producedObjects;
      }
    }
}
