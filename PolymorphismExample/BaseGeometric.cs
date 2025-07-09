namespace PolymorphismExample;

public abstract class BaseGeometric  //Base oldugu icin new ile nesne olusturulmasin diye Abstract tanimlanir
{
    public int Height { get; set; }
    public int Width { get; set; }

    public virtual void AreaCalculate() //miras alan classlar override etsin diye virtual tanimlanir.
    {
        Console.WriteLine("Area Calculate");   
    }
}