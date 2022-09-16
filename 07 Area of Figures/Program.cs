using System;

namespace _07_Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string figure = Console.ReadLine();
                     
            
            if (figure=="square")
            {
                                          
                double a = double.Parse(Console.ReadLine());
                double areaSquare = a * a;
                Console.WriteLine($"{areaSquare:F3}");
            }
            else if (figure=="rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b =  double.Parse(Console.ReadLine());
                double areaRectangle = a * b;
                Console.WriteLine($"{areaRectangle:F3}");
            }
            else if (figure=="circle")
            {
                double r = double.Parse(Console.ReadLine());
                double areaCircle = Math.PI*r*r;
                Console.WriteLine($"{areaCircle:F3}");
            }
            else if(figure=="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double areaTriangle = a * h/2;
                Console.WriteLine($"{areaTriangle:F3}");
            }

        }
    }
}
