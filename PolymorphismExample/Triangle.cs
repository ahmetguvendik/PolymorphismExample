namespace PolymorphismExample;

public class Triangle : BaseGeometric
{
    public override void AreaCalculate()
    {
        int area = (Height * Width)/2;
        Console.WriteLine($"Alan Degeri --> {area}");
    }
}