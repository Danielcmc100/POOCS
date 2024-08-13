public abstract class Animal
{
    public abstract void Comer();
}

public class Leao : Animal
{
    public override void Comer()
    {
        Console.WriteLine("Comendo carne");
    }
}

public class Pato : Animal
{
    public override void Comer()
    {
        Console.WriteLine("Comendo pão");
    }
}
public class Program
{
    public static void Main()
    {
        // System.Console.WriteLine("Hello, World!2");
        Animal simba = new Leao();
        simba.Comer();

        Animal patoAzul = new Pato();
        patoAzul.Comer();

    }
}

