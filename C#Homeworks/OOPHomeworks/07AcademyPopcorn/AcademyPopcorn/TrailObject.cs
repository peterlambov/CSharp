using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class TrailObject:GameObject
    {
        private int lifeTime;
        public TrailObject(MatrixCoords topLeft, char[,] body, int lifetime)
            : base(topLeft, body)
        {
            this.LifeTime = lifetime;
        }
        public int LifeTime
        {
            get
            {
                return this.lifeTime;
            }
            set
            {
                this.lifeTime = value;
            }
        }
        public override void Update()
        {
            this.LifeTime--;
            if (this.LifeTime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
