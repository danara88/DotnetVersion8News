namespace DotnetVersion8News;

public class CLambdaFunctions
{
    public static void ExecuteCode()
    {
        // En C# 12 ya puedes ponerle un valor por defecto a los parametros
        var mul = (double a, double b = 10) => a * b;
        Console.WriteLine(mul(1));
    }
}