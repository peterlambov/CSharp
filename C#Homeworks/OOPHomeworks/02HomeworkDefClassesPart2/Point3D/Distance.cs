using System;
using System.Linq;

 public static class Distance
{
    public static double CalculateDistance(Point3D firstPoint,Point3D secondPoint)
    {
        double result = 0;
        result = Math.Sqrt(Math.Pow(secondPoint.X - firstPoint.X, 2) + Math.Pow(secondPoint.Y - firstPoint.Y, 2) + Math.Pow(secondPoint.Z - firstPoint.Z, 2));
        return result;
    }
}

