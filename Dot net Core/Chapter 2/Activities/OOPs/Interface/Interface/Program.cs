using Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        IVehicle myCar = new Car();  // Using interface reference
        myCar.Start();
    }
}