internal class Program
{
    private static void Main(string[] args)
    {
        double[] ProductPrice = new double[6];
        Console.WriteLine("Enter the product price!");
        for (int i = 0; i < ProductPrice.Length; i++)
        {
            ProductPrice[i]=Convert.ToDouble(Console.ReadLine());
        }
        double highest = double.MinValue;
        double lowest=double.MaxValue;
        int indice = -1; double sum = 0;
        for(int i = 0;i < ProductPrice.Length;i++)
        {
            sum += ProductPrice[i];
            if(ProductPrice[i] > highest)
            {
                highest = ProductPrice[i];

            }
            if(ProductPrice[i] < lowest)
            {
                lowest = ProductPrice[i];
            }
        }
        Console.WriteLine("Highest Price is: " + highest);
        Console.WriteLine("Lowest Price is: " + lowest);
        double average = sum / ProductPrice.Length;
        Console.WriteLine("Average is: " + average);
        for (int i = 0;i<ProductPrice.Length;i++)
        {
            if(ProductPrice[i] > average)
            {
             
                indice = i + 1;
                Console.WriteLine("Products withe price above average: \n"+"Indice: "+indice+"\n price: "+ProductPrice[i]); 
            }
        }
        
    }
}