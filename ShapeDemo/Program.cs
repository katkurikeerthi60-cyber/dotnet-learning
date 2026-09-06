using System;
using System.Collections.Generic;

List<IShape> shapes = new List<IShape>
{
    new Circle(5),
    new Rectangle(10, 5),
    new Triangle(3, 4, 5),
    new Pentagon(6)
};

foreach (IShape shape in shapes)
{
    Console.WriteLine($"Shape: {shape.Name}");
    Console.WriteLine($"Area: {shape.CalculateArea():F2}");
    Console.WriteLine($"Perimeter: {shape.CalculatePerimeter():F2}");
    Console.WriteLine();
}

public interface IShape
{
    string Name { get; }
    double CalculateArea();
    double CalculatePerimeter();
}

public abstract class Shape : IShape
{
    public string Name { get; protected set; }

    protected Shape(string name)
    {
        Name = name;
    }

    public abstract double CalculateArea();

    public virtual double CalculatePerimeter()
    {
        return 0;
    }
}

public sealed class Circle : Shape
{
    private double Radius { get; }

    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : Shape
{
    private double Length { get; }
    private double Width { get; }

    public Rectangle(double length, double width) : base("Rectangle")
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}

public class Triangle : Shape
{
    private double A { get; }
    private double B { get; }
    private double C { get; }

    public Triangle(double a, double b, double c) : base("Triangle")
    {
        A = a;
        B = b;
        C = c;
    }

    public override double CalculateArea()
    {
        double s = (A + B + C) / 2;

        return Math.Sqrt(
            s * (s - A) * (s - B) * (s - C)
        );
    }

    public override double CalculatePerimeter()
    {
        return A + B + C;
    }
}

public class Pentagon : Shape
{
    private double Side { get; }

    public Pentagon(double side) : base("Pentagon")
    {
        Side = side;
    }

    public override double CalculateArea()
    {
        return (Math.Sqrt(25 + 10 * Math.Sqrt(5)) * Side * Side) / 4;
    }

    public override double CalculatePerimeter()
    {
        return 5 * Side;
    }
}