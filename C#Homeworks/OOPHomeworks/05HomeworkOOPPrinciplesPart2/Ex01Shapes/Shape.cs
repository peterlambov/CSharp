using System;
using System.Linq;

public abstract class Shape
{
      private int width;
      private int height;

      public Shape(int width, int height)
      {
          this.Width = width;
          this.Height = height;
      }

    public int Width
    {
        get
        {
            return this.width;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            }
            this.width = value;
        }
    }

    public int Height
    {
        get
        {
            return this.height;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            }
            this.height = value;
        }
    }

    public virtual double CalculateSurface()
    {
        return -1;
    }
   
    
}

