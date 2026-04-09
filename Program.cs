using System;

abstract class Figure
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public void PrintInfo()
    {
        Console.WriteLine($"{GetType().Name}: Площадь = {GetArea():F2}, Периметр = {GetPerimeter():F2}");
    }
}

class Circle : Figure
{
    public double Radius;
    public Circle(double r) { Radius = r; }
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}

class Rectangle : Figure
{
    public double W, H;
    public Rectangle(double w, double h) { W = w; H = h; }
    public override double GetArea() => W * H;
    public override double GetPerimeter() => 2 * (W + H);
}

class Program
{
    static void Main()
    {
        Figure[] figs = { new Circle(5), new Rectangle(4, 7), new Circle(2.5) };
        foreach (var f in figs) f.PrintInfo();
    }
}
