namespace DotnetVersion8News;

public class EArrayLimit
{
    public static void ExecuteCode()
    {
        var beers = new Beers();

        for (int i = 0; i < 10; i++)
        {
            beers[i] = "some";
        }
        foreach (var beer in beers)
        {
            Console.WriteLine(beer);
        }
    }
}

// Puedes especificar cuantos elementos puede tener una coleccion
[System.Runtime.CompilerServices.InlineArray(10)]
public struct Beers
{
    private string _name;
}