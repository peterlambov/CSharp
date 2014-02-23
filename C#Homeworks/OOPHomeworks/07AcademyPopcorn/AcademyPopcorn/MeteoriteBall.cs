using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MeteoriteBall:Ball
    {
       
       public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
           : base(topLeft, speed)
       {
           
       }
      

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> allObjects = new List<GameObject>();
            allObjects.Add(new TrailObject(base.topLeft,new char[,] {{'*'}},3));
            return allObjects;
        }
    }
}
