using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometry
{
    class ExtendedFigureController:FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {

            switch (splitFigString[0])
            {
                case "vertex":
                    {
                        Vector3D location = Vector3D.Parse(splitFigString[1]);
                        currentFigure = new Vertex(location);
                        break;
                    }
                case "segment":
                    {
                        Vector3D a = Vector3D.Parse(splitFigString[1]);
                        Vector3D b = Vector3D.Parse(splitFigString[2]);
                        currentFigure = new LineSegment(a, b);
                        break;
                    }
                case "triangle":
                    {
                        Vector3D a = Vector3D.Parse(splitFigString[1]);
                        Vector3D b = Vector3D.Parse(splitFigString[2]);
                        Vector3D c = Vector3D.Parse(splitFigString[3]);
                        currentFigure = new Triangle(a, b, c);
                        break;
                    }
                case "circle":
                    {
                        Vector3D center = Vector3D.Parse(splitFigString[1]);
                        double radius = double.Parse(splitFigString[2]);
                        this.currentFigure = new Circle(center, radius);
                        break;
                    }
                case "cylinder":
                    {
                        Vector3D top = Vector3D.Parse(splitFigString[1]);
                        Vector3D bottom = Vector3D.Parse(splitFigString[2]);
                        double radius = double.Parse(splitFigString[3]);
                        this.currentFigure = new Cylinder(top, bottom, radius);
                        break;
                    }

            }

            this.EndCommandExecuted = false;
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            {
                case "translate":
                    {
                        Vector3D transVector = Vector3D.Parse(splitCommand[1]);
                        this.currentFigure.Translate(transVector);
                        break;
                    }
                case "rotate":
                    {
                        Vector3D center = Vector3D.Parse(splitCommand[1]);
                        double degrees = double.Parse(splitCommand[2]);
                        this.currentFigure.RotateInXY(center, degrees);
                        break;
                    }
                case "scale":
                    {
                        Vector3D center = Vector3D.Parse(splitCommand[1]);
                        double factor = double.Parse(splitCommand[2]);
                        this.currentFigure.Scale(center, factor);
                        break;
                    }
                case "center":
                    {
                        Vector3D figCenter = this.currentFigure.GetCenter();
                        Console.WriteLine(figCenter.ToString());
                        break;
                    }
                case "measure":
                    {
                        Console.WriteLine("{0:0.00}", this.currentFigure.GetPrimaryMeasure());
                        break;
                    }
                case "area":
                    {

                        IAreaMeasurable temp = this.currentFigure as IAreaMeasurable;
                        if (temp != null)
                        {
                            Console.WriteLine("{0:0.00}", temp.GetArea());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "volume":
                    {
                        IVolumeMeasurable temp = this.currentFigure as IVolumeMeasurable;
                        if (temp != null)
                        {
                            Console.WriteLine("{0:0.00}",temp.GetVolume());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "normal":
                    {
                        IFlat temp = this.currentFigure as IFlat;
                        if (temp != null)
                        {
                            Console.WriteLine("{0:0.00}",temp.GetNormal());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
            }
        }
    }
}
