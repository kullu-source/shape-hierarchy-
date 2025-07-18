using System;

class Program
{
    static void Main()
    {
        // Polymorphism in action!
        Shape circle = new Circle(5.0);
        Shape rectangle = new Rectangle(4.0, 8.0);

        Console.WriteLine($"{circle.Name} Area: {circle.CalculateArea()}"); 
        Console.WriteLine($"{rectangle.Name} Area: {rectangle.CalculateArea()}");
    }
}
