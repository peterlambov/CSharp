using System;
using System.Collections.Generic;
using System.Linq;


public class Path
{
    public readonly List<Point3D> listOfPoints = new List<Point3D>();

    public void AddPoint(Point3D point)
    {
        this.listOfPoints.Add(point);
    }

    public void RemovePoint(Point3D point)
    {
        this.listOfPoints.Remove(point);
    }

    public void ClearListOfPoints()
    {
        this.listOfPoints.Clear();
    }
}

