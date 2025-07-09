namespace PolymorphismExample;

public class Square : BaseGeometric
{
    public override void AreaCalculate()
    {
        int area = Height * 2;
        Console.WriteLine($"Alan Degeri --> {area}");
    }
}