using GeometryCalculator.Models;

namespace GeometryCalculator.Tests;

internal class ShapeTests
{
    [Test]
    public void Equilateral_Triangle_Area_Is_Correct()
    {
        double side = 6;
        var triangle = new Triangle(side, side, side);
        double expectedArea = (Math.Sqrt(3) / 4) * side * side;
        double actualArea = triangle.CalculateArea();

        Assert.That(actualArea, Is.EqualTo(expectedArea));
    }

    [Test]
    public void StraightAngled_Triangle_Area_Is_Correct()
    {
        var triangle = new Triangle(3, 4, 5);
        double expectedArea = 6;
        Assert.That(triangle.IsStraightAngled, Is.EqualTo(true));
        Assert.That(expectedArea, Is.EqualTo(triangle.CalculateArea()));
    }

    [Test]
    public void NonExistant_Triangle_Exception_Thrown()
    {
        var triangle = new Triangle(3, 4, 20);
        Assert.Throws<InvalidOperationException>(() => triangle.CalculateArea() );
    }

    [Test]
    public void Is_CircleArea_Correct()
    {
        var circle = new Circle(10);
        double expectedArea = Math.PI * 100;
        Assert.That(expectedArea, Is.EqualTo(circle.CalculateArea()));
    }

    [Test]
    public void Should_Throw_Exception_When_Negative_Radius()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-10));
    }
    
    [Test]
    public void Should_Throw_Exception_When_Change_Radius()
    {
        var circle = new Circle(10);
        Assert.Throws<ArgumentException>(() => circle.Radius = -10);
    }   
    
    [Test]
    public void Should_Throw_Exception_When_Negative_Sides()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-10, -20, 30));
    }

    [Test]
    public void Should_Throw_Exception_When_Change_Triangle_Sides()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Throws<ArgumentException>(() => triangle.B = -10);
    }
    
    [Test]
    public void Should_Detect_Which_Area_Formula_Should_Be_Used()
    {
        var circle = new Circle(15);
        var expectedCircleArea = Math.PI * 225;
        
        var triangle = new Triangle(30, 40, 50);
        var expectedTriangleArea = 600;
        
        Assert.That(GeometryHelper.CalculateShapeArea(circle), Is.EqualTo(expectedCircleArea));
        Assert.That(GeometryHelper.CalculateShapeArea(triangle), Is.EqualTo(expectedTriangleArea));
    }
}