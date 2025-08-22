internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Three Numbers!");
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());
        int num3=Convert.ToInt32(Console.ReadLine());
        if(num1>num2)
        {
            if(num1>num3)
            {
                Console.WriteLine(num1+" is the largest Number");
                
            }
        }
        else if(num2>num3) 
        {
            Console.WriteLine(num2 + " is the largest Number");
            
        }
        else
        {
            Console.WriteLine(num3 + " is the largest Number");
            
        }
    }
}