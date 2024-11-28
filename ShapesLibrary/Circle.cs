namespace ShapesLibrary;

public class Circle:IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public double GetArea() => Math.PI * Math.Pow(Radius, 2);//S = pi*R^2

}
