using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometry
{
    class Cylinder:Figure,IAreaMeasurable,IVolumeMeasurable
    {
        public double Radius { get; private set; }
        public Cylinder(Vector3D bottomCenter,Vector3D topCenter,double radius) : base(topCenter,bottomCenter)
        {
            this.Radius = radius;
        }

        public Vector3D TopCenter
        {
            get
            {
                return new Vector3D(this.vertices[0].X, this.vertices[0].Y, this.vertices[0].Z);
            }
            private set
            {
                this.vertices[0] = new Vector3D(value.X, value.Y, value.Z);
            }
        }

        public Vector3D BottomCenter
        {
            get
            {
                return new Vector3D(this.vertices[1].X, this.vertices[1].Y, this.vertices[1].Z);
            }
            private set
            {
                this.vertices[1] = new Vector3D(value.X, value.Y, value.Z);
            }
        }

        public double GetArea()
        {
            double baseArea = this.Radius * this.Radius * Math.PI;
            double topAndBottomArea = baseArea * 2;

            double basePerimeter = 2 * Math.PI * this.Radius;

            double sideArea = basePerimeter * (this.TopCenter - this.BottomCenter).Magnitude;

            return sideArea + topAndBottomArea;
        }

        public double GetVolume()
        {
            return Math.PI * this.Radius * this.Radius * (this.TopCenter - this.BottomCenter).Magnitude;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetVolume();
        }
    }
}
