namespace PolymorphismExample;

public abstract class BaseGeometric
{
    public int Height { get; set; }
    public int Width { get; set; }

    public virtual void AreaCalculate()
    {
        Console.WriteLine("Area Calculate");   
    }
}