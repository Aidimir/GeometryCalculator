namespace GeometryCalculator.Models;

public class Circle : Shape
{
    public double Radius
    {
        get => _radius;

        set => _radius = Validate(value);
    }

    private double _radius;

    public Circle(double radius)
    {
        _radius = Validate(radius);
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    protected override double Validate(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным числом.");
       
        return radius;
    }
}