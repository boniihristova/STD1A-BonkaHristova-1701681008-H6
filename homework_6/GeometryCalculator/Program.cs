using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option(triangle,square or radians)");
            string figureType = Console.ReadLine().ToLower();
            switch (figureType)
            {
                case "triangle":
                    Console.WriteLine("Enter side");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("The are of the triangle is = {0:f2}", PrintTriangleArea(b, h));
                    break;
                case "square":
                    Console.WriteLine("Enter side");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("The are of the square is = {0:f2}", PrintSquareArea(a));
                    break;
                case "radians":
                    Console.WriteLine("Enter  the degrees ypu want to transform in radians");
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("Your degrees in radians are = {0:f2}", PrintRadiansArea(r));
                    break;


            }
        }
        static double PrintTriangleArea(double b, double h)
        {
            return (b * h) / 2;
        }
        static double PrintSquareArea(double a)
        {
            return a * a;
        }
        static double PrintRadiansArea(double r)
        {
            return Math.PI * r / 180.0;
        }
      
        
    }
}
      
