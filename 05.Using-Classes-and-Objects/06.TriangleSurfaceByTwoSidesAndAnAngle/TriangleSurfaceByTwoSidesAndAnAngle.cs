using System;

class TriangleSurfaceByTwoSidesAndAnAngle
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        double area = (a * b * Math.Sin(angle * Math.PI / 180)) / 2;

        Console.WriteLine("{0:F2}", area);
    }
}