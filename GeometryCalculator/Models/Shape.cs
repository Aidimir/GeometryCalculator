namespace GeometryCalculator.Models;

public abstract class Shape
{
    public abstract double CalculateArea();
    
    protected abstract double Validate(double value);
}