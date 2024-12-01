namespace GeometryCalculator.Models;

public class Triangle : Shape
{
    public double A
    {
        get => _a;
        set => _a = Validate(value);
    }

    public double B
    {
        get => _b;
        set => _b = Validate(value);
    }

    public double C
    {
        get => _c;
        set => _c = Validate(value);
    }

    public bool IsStraightAngled
    {
        get
        {
            var sides = new List<double> { _a, _b, _c };
            sides.Sort();
            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-9;
        }
    }

    private double _a;
    private double _b;
    private double _c;

    public Triangle(double a, double b, double c)
    {
        _a = Validate(a);
        _b = Validate(b);
        _c = Validate(c);
    }

    public override double CalculateArea()
    {
        double semiPerimeter = (_a + _b + _c) / 2;
        if (semiPerimeter - _a <= 0 || semiPerimeter - _b <= 0 || semiPerimeter - _c <= 0)
        {
            throw new InvalidOperationException("Треугольник с указанными сторонами не может существовать.");
        }
        
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _a) * (semiPerimeter - _b) * (semiPerimeter - _c));
    }

    protected override double Validate(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Сторона треугольника должна быть больше нуля");
        
        return side;
    }
}