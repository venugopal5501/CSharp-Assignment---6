using System;


class shape
{
    public virtual void getPerimeter()
    {
        Console.Write("Perimeter Calculation will be done here ");

    }
    public virtual void getArea()
    {
        Console.Write("Area Calculation will be done here ");
    }
}

class Circle : shape
{
    double radius;
    double area;

    public Circle(double area, double radius)
    {
        this.area = area;
        this.radius = radius;
    }

    public override void getPerimeter()
    {
        double c = 2 * 3.14 * radius;
        Console.WriteLine("The Perimeter of a circle is : " + c);

    }

    public override void getArea()
    {
        double d = 3.14 * area * area;
        Console.WriteLine("The Area of a circle is : " + d);

    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Radius of a circle : ");
        double area = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Radius of a circle : ");
        double radius = Convert.ToInt32(Console.ReadLine());
        Circle c = new Circle(area, radius);
        c.getPerimeter();
        c.getArea();
    }
}