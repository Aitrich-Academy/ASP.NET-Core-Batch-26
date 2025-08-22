internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter 5 numbers!");
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Array in ascending order: ");
        foreach (int i in numbers)
        {
            Console.Write(i + " ");


        }
    }
}