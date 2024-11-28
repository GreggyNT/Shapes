using System.ComponentModel;

namespace ShapesLibrary;

public class ShapeFactory
{
    public static IShape CreateShape(string type, params double[] parameters)
    {
        type = type.ToLower();
        return type switch
        {
            ("circle") => new Circle(parameters[0]),
            ("triangle") => new Triangle(parameters[0], parameters[1], parameters[2]),
            _ => throw new ArgumentException("Форма не поддерживается")
        };
    }
}