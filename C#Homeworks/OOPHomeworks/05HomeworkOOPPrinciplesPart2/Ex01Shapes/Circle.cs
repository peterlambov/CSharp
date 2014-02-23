using System;
using System.Linq;
   public class Circle:Shape
    {
       public Circle(int width, int height)
           : base(width, height)
       {
           if (width!=height)
           {
               throw new ArgumentException();
           }
       }

       public override double CalculateSurface()
       {
           return this.Width * this.Height * Math.PI;//assuming that width = height = R(radius of the circle)
       }

    }

