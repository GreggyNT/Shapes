using ShapesLibrary;

namespace ShapesUnitTests;

public class FactoryTests
{
    [Test]
    public void ShapeFactory_CreateShape_CorrectShapeTypeCircle()
    {
        // Arrange
        const double radius = 5;
        // Act
        var circle = ShapeFactory.CreateShape("Circle", radius);
        // Assert
        Assert.That(circle.GetType(),Is.EqualTo(typeof(Circle)));
    }

    [Test]
    public void ShapeFactory_CreateShape_CorrectShapeTypeTriangle()
    {
        // Arrange
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        // Act 
        var triangle = ShapeFactory.CreateShape("Triangle", sideA, sideB, sideC);
        // Assert
        Assert.That(triangle.GetType(),Is.EqualTo(typeof(Triangle)));
    }
}