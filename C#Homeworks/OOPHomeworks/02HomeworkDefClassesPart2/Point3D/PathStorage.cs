using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;



public static class PathStorage
{
    public static void SavePath(Path path)
    {
        using (StreamWriter writer = new StreamWriter(@"../../textFile.txt"))
        {
            foreach (var point in path.listOfPoints)
            {
                writer.WriteLine(point);
            }
        }
    }

    public static List<Path> LoadPath()
    {
        Path loadPath = new Path();
        List<Path> loadedPaths = new List<Path>();
        using (StreamReader reader = new StreamReader(@"../../textFile.txt"))
        {
            string line = reader.ReadLine();
            while (line!=null)
            {
                if (line!=";")
                {
                    Point3D point = new Point3D();
                    string[] points = line.Split(',');
                    point.X = int.Parse(points[0]);
                    point.Y = int.Parse(points[1]);
                    point.Z = int.Parse(points[2]);
                    loadPath.AddPoint(point);
                }
                else
                {
                    loadedPaths.Add(loadPath);
                    loadPath = new Path();
                }
                line = reader.ReadLine();
            }
        }
        return loadedPaths;
    }
}

