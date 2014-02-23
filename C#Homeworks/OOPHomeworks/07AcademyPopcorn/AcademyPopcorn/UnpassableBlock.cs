using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
   public class UnpassableBlock:Block
    {
       public const char Sign = '!';
       public new const string CollisionGroupString = "unpassableBlock";
       public UnpassableBlock(MatrixCoords topLeft)
           : base(topLeft)
       {
           this.body[0,0] = Sign;
       }

       public override string GetCollisionGroupString()
       {
           return UnpassableBlock.CollisionGroupString;
       }

       public override void RespondToCollision(CollisionData collisionData)
       {
           
       }
    }
}
