using System;
public abstract class Shape
{
    protected double width, height, radius;
    protected const float pi = 3.14f;
    public abstract double GetArea();
}
public class Rectangle: Shape
{
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public override double GetArea()
    {
        return width * height;
    }
}
public class Circle : Shape
{
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        return pi * radius * radius;
    }
}

public class MainClass
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle(5.5, 10.3);
        Circle c = new Circle(6.7);

        Console.WriteLine("Area of Rectangle is : {0}",r.GetArea());
        Console.WriteLine("Area of Circle is : {0}", c.GetArea());
    }
}