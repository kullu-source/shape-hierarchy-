using System;

class Program
{
    static void Main()
    {
        // Polymorphism in action!
        Shape circle = new Circle(5.0);
        Shape rectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine($"{circle.Name} Area: {circle.CalculateArea()}"); // 78.54
        Console.WriteLine($"{rectangle.Name} Area: {rectangle.CalculateArea()}"); // 24
    }
}
