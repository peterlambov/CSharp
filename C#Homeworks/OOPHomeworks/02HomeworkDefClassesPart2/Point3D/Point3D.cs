using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[VersionAttribute(2.9)]
public struct Point3D
{
    private int x;
    private int y;
    private int z;

    public static readonly Point3D startOfSystem = new Point3D(0, 0, 0);
    public Point3D(int x, int y, int z)
        : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public int X
    {
        get { return this.x; }
        set { this.x = value; }
    }

    public int Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    public int Z
    {
        get { return this.z; }
        set { this.z = value; }
    }


    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendFormat("Coordinate X = {0}\nCoordinate Y = {1}\nCoordinate Z = {2}", this.x, this.y, this.z);
        string final = result.ToString();
        return final;

    }

}

