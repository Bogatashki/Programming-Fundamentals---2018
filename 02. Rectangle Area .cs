using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());

            double area = side1 * side2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
