internal class Program
{
    private static void Main(string[] args)
    {
        int[] array1 = new int[5];
        int[] array2 = new int[5];
        int[] array3 = new int[10];
        Console.WriteLine("Enter elements of first array!");
        for(int i = 0; i < array1.Length; i++)
        {
            array1[i] = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine("Enter elements of second array!");
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0;i < array1.Length; i++)
        {
            array3[i]=array1[i];
            
        }
        for(int i=0; i < array2.Length; i++)
        {
            array3[array1.Length+i] = array2[i];
        }
        Console.WriteLine("Array after Merging");
        foreach(int i in array3)
        {
            Console.Write(i+" ");
        }
    }
}