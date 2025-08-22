using Abstract_Class;

internal class Program
{
    private static void Main(string[] args)
    {
        Shape shape = new Circle();  // Using parent reference
        shape.Draw();

    }
}