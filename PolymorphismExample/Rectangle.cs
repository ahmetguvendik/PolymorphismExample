namespace PolymorphismExample;

public class Rectangle : BaseGeometric
{
    public override void AreaCalculate() //override ile virtual tanimlanan metot kendimize gore ayarlanir
    {
        int area = Height * Width;
        Console.WriteLine($"Alan Degeri --> {area}");
    } 
}
