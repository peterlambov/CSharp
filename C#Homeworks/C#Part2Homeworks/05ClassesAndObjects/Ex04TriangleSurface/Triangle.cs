//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
using System;
using System.Linq;
namespace Ex04TriangleSurface
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter:");
            Console.WriteLine("1 to calculate the area by given side and altitude"); 
            Console.WriteLine("2 to calculate it by given three sides");
            Console.WriteLine("3 to calculate by given two sides and an angle between them");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1: Console.WriteLine("Enter side and an altitude:");
                    double side = double.Parse(Console.ReadLine());
                    double altitude = double.Parse(Console.ReadLine());
                    Console.WriteLine(Area(side, altitude));
                    break;
                case 2: Console.WriteLine("Enter the three sides");
                    double firstSide = double.Parse(Console.ReadLine());
                    double secondSide = double.Parse(Console.ReadLine());
                    double thirdSide = double.Parse(Console.ReadLine());
                    Console.WriteLine(Area(firstSide, secondSide, thirdSide));
                    break;
                case 3: Console.WriteLine("Enter the two sides and the angle:");
                    double firstSide1 = double.Parse(Console.ReadLine());
                    double secondSide1 = double.Parse(Console.ReadLine());
                    int angle = int.Parse(Console.ReadLine());
                    Console.WriteLine(Area(firstSide1, secondSide1, angle));
                    break;
                default:
                    break;
            }
        }

         static double Area(double side,double altitude)
           {
            double area = (side * altitude) / 2;
            Console.Write("Area:");
            return area;
           }

         static double Area(double firstSide, double secondSide, double thirdSide)
        {
            double halfPerimeter= (firstSide + secondSide + thirdSide) / 2;
            double area1 = Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) *
                (halfPerimeter - thirdSide));
            Console.Write("Area:");
            return area1;
        }

         static double Area(double firstSide1, double secondSide1, int angle)
        {

            
            double area2 = (firstSide1 * secondSide1*Math.Sin((angle*Math.PI)/180)) / 2;
            Console.Write("Area:");
            return area2;
        }
             
    
    }
}
