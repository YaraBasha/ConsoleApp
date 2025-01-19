using System;




interface IShape
{
    double Area { get; }
    void DisplayShape();
}

class Circle : IShape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Area => Math.PI * Radius * Radius;
    public void DisplayShape()
    {
        Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
    }
}

class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    public double Area => Length * Width;
    public void DisplayShape()
    {
        Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape circle = new Circle(5);
        circle.DisplayShape();

        IShape rectangle = new Rectangle(10, 4);
        rectangle.DisplayShape();
    }
}
// Result : Circle: Radius = 5, Area = 78.54
//Rectangle: Length = 10, Width = 4, Area = 40.00

