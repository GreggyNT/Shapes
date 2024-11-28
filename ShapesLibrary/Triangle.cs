namespace ShapesLibrary;

public class Triangle:IShape
{
    private double[] Sides { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        Sides = [sideA, sideB, sideC];
    }
    
    public double GetArea()
    {
        var halfPerimeter = Sides.Sum() / 2; // Половина периметра для формулы нахождения площади 
        return Math.Sqrt(halfPerimeter * (halfPerimeter - Sides[0]) *
                         (halfPerimeter - Sides[1]) * (halfPerimeter - Sides[2])); // S = √p · (p — a)(p — b)(p — c)
    }

    public bool IsRight()
    {
        var sortedSides = Sides.OrderBy(x=>x).ToArray(); //Сортировка для нахождения гипотенузы
        
        var leg1Sqr = Math.Pow(sortedSides[0], 2); 
        var leg2Sqr = Math.Pow(sortedSides[1], 2); //Расчёт квадратов 
        var hypotenuseSqr = Math.Pow(sortedSides[2], 2);
        
        return Math.Abs(leg1Sqr + leg2Sqr - hypotenuseSqr) < 1e-10;
    }
    
}