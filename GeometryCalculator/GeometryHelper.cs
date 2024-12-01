using GeometryCalculator.Models;

namespace GeometryCalculator;

public static class GeometryHelper
{
    public static double CalculateShapeArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}