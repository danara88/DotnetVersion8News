namespace DotnetVersion8News;

public class Beer
{
    public string Name { get; set; }

    public Beer(string name)
    {
        Name = name;
    }
}

public class BeerPrimaryConstructor(string _name)
{
    public string Name = _name;
}

public class APrimaryConstructors
{
    public static void ExecuteCode()
    {
        var beer = new BeerPrimaryConstructor("Heineken");
        Console.WriteLine(beer.Name);
    }
}