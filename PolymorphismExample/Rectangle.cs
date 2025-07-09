namespace PolymorphismExample;

public class Rectangle : BaseGeometric
{
    public override void AreaCalculate()
    {
        int area = Height * Width;
        Console.WriteLine($"Alan Degeri --> {area}");
    } 
}
