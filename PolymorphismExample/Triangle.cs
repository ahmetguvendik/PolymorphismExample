namespace PolymorphismExample;

public class Triangle : BaseGeometric
{
    public override void AreaCalculate() //override ile virtual tanimlanan metot kendimize gore ayarlanir
    {
        int area = (Height * Width)/2;
        Console.WriteLine($"Alan Degeri --> {area}");
    }
}