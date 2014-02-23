using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
   public class ExplodingBlock:Block
    {
       public ExplodingBlock(MatrixCoords topLeft)
           : base(topLeft)
       {
       }

       public override void RespondToCollision(CollisionData collisionData)
       {
           this.IsDestroyed = true;
       }

       public override IEnumerable<GameObject> ProduceObjects()
       {
           List<GameObject> list = new List<GameObject>();
           list.Add(new Explosion(this.topLeft, new char[,] { { '~' } }, new MatrixCoords(-1, 0)));
           list.Add(new Explosion(this.topLeft, new char[,] { { '~' } }, new MatrixCoords(1, 0)));
           list.Add(new Explosion(this.topLeft, new char[,] { { '~' } }, new MatrixCoords(0, 1)));
           list.Add(new Explosion(this.topLeft, new char[,] { { '~' } }, new MatrixCoords(0, -1)));
           return list;
       }
    }
}
