using System;
// Upologismos evmvadou trigwnou me tin tupo tou Heron
namespace Emvadon
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            Console.WriteLine("Type a side :");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Type b side :");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Type c side :");
            double c = double.Parse(Console.ReadLine());

            //PROCESSING
            double area = CalculationArea(a, b, c);

            //OUTPUT
            Console.WriteLine("The Area of the Triangle is {0}", area);
        }

        static double CalculationArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
    }
}
