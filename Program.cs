namespace InheritanceApp;

public abstract class Figure
{
    public abstract double CalculateArea();
}

public class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}


public class RightTriangle : Figure
{
    public double Base { get; set; }
    public double Height { get; set; }

    public RightTriangle(double baseLength, double height)
    {
        Base = baseLength;
        Height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}

public class Trapezoid : Figure
{
    public double Base1 { get; set; }
    public double Base2 { get; set; }
    public double Height { get; set; }

    public Trapezoid(double base1, double base2, double height)
    {
        Base1 = base1;
        Base2 = base2;
        Height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * (Base1 + Base2) * Height;
    }
}
class Program
{
    static void Main()
    {
        Figure[] figures = new Figure[]
        {
            new Rectangle(10, 15),
            new Circle(7),
            new RightTriangle(5, 6),
            new Trapezoid(3, 5, 4)
        };

        foreach (var figure in figures)
        {
            Console.WriteLine($"Area of {figure.GetType().Name}: {figure.CalculateArea()}");
        }
    }
}


/*
Area of Rectangle: 150
Area of Circle: 153,93804002589985
Area of RightTriangle: 15
Area of Trapezoid: 16

C:\Users\David\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe (процесс 4408) завершил работу с кодом 0 (0x0).
Нажмите любую клавишу, чтобы закрыть это окно:

*/
