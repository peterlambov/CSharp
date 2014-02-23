using System;
[VersionAttribute(3.9)]
public class testingAttribute
{
    public static void Main()
    {
        Point3D point = new Point3D(1, 2, 3);
        Type type = typeof(Point3D);
        object[] attributes = type.GetCustomAttributes(false);
        foreach (VersionAttribute attribute in attributes)
        {
            Console.WriteLine("{0} {1}",attribute,attribute.Version);
        }
    }
}
