public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Name = "Circle";
        Radius = radius;
    }
    public override double CalculateArea() => Math.PI * Radius * Radius;

}


