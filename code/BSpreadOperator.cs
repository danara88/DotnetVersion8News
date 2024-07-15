namespace DotnetVersion8News;

public class BSpreadOperator
{
    public static void ExecuteCode()
    {
        // Spread operator
        string[] beers1 = ["Sol", "Corona"];
        string[] beers2 = ["Heineken", "Erdinger"];
        string[] beers3 = ["Guinness", "Delirium"];

        string[] beers = [..beers1, ..beers2, ..beers3];

        foreach (string beer in beers)
        {
            Console.WriteLine(beer);
        }
    }
}