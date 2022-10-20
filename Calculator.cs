namespace ShapeCalcApi;

public interface ICalculator
{
    double GetCircleArea(double radius);
    double GetRectArea(double a, double b);
    double GetTriangleArea(double a, double b, double c);
}
 
public class Calculator : ICalculator
{
    public double GetCircleArea(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2); 
        return Math.Round(area, 2);
    }

    public double GetRectArea(double a, double b)
    {
        double area = a * b;
        return Math.Round(area, 2);
    }

    public double GetTriangleArea(double a, double b, double c)
    {
        // get hypotenus
        List<double> sides = new List<double>(){a, b, c};
        double hypus = sides.Max();
        sides.Remove(hypus);
        double side1 = sides[0], side2 = sides[1];

        bool rightTriangle = hypus * hypus == (side1 * side1) + (side2 * side2); 
        if (rightTriangle) {
            // Avengers assemble!
        }

        // half of perimeter
        double p = (a + b + c) / 2;

        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return Math.Round(area, 2);
    }

}