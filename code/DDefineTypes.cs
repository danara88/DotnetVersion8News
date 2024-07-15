namespace DotnetVersion8News;

// Nos permite crear un tipo rapido sin tener que crear una clase o un record.
// Esta estructura es una tupla
using BeerObj = (string name, decimal price);
public class DDefineTypes
{
    public static void ExecuteCode()
    {
        BeerObj beer = new BeerObj() { name = "Corona", price = 18 };
        Console.WriteLine(beer.name);
        Console.WriteLine(beer.price); 
        beer.name = "Valor cambaiado";
    }
}