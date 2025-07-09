namespace PolymorphismExample;

public class Square : BaseGeometric
{
    public override void AreaCalculate() //override ile virtual tanimlanan metot kendimize gore ayarlanir
    {
        int area = Height * 2;
        Console.WriteLine($"Alan Degeri --> {area}");
    }
}