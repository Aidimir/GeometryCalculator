namespace GeometryCalculator.Models;

public class Circle : IShape
{
    public double Radius
    {
        get => _radius;

        set => _radius = ValidateRadius(value);
    }

    private double _radius;

    public Circle(double radius)
    {
        _radius = ValidateRadius(radius);
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    private double ValidateRadius(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным числом.");
       
        return radius;
    }
}