using GeometryCalculator.Models;

namespace GeometryCalculator;

public static class GeometryHelper
{
    public static double CalculateShapeArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}