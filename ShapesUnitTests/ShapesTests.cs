using ShapesLibrary;

namespace ShapesUnitTests;

public class Tests
{
    [Test]
    public void Circle_GetArea_ReturnsCorrectArea()
    {
        // Arrange
        var radius = 5;
        var expectedArea = Math.PI * Math.Pow(radius, 2);
        var circle = new Circle(radius);
        // Act
        var actualArea = circle.GetArea();
        // Assert
        Assert.That(expectedArea,Is.EqualTo(actualArea).Within(1e-10));
    }

    [Test]
    public void Triangle_GetArea_ReturnsCorrectArea()
    {
        // Arrange
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        const double expectedArea = 6; // Площадь прямоугольного треугольника с такими сторонами
        var triangle = new Triangle(sideA, sideB, sideC);
        // Act
        var actualArea = triangle.GetArea();
        // Assert
        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1e-10));
    }

    [Test]
    public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
    {
        // Arrange
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);
        // Act
        var isRightAngled = triangle.IsRight();
        // Assert
        Assert.That(isRightAngled, Is.True);
    }

    [Test]
    public void Triangle_IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
    {
        // Arrange
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 6;
        var triangle = new Triangle(sideA, sideB, sideC);
        // Act
        var isRightAngled = triangle.IsRight();
        // Assert
        Assert.That(isRightAngled, Is.False);
    }
}