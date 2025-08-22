using Method_Overloading;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(2, 3));          
        Console.WriteLine(calc.Add(2.5, 3.5));      
        Console.WriteLine(calc.Add(1, 2, 3));
    }
}