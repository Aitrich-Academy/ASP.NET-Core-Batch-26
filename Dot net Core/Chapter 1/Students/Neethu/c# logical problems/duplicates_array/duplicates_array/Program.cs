internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter 10 numbers including duplicate numbers!");
        int[] numbers=new int[10];
        
        for(int i=0; i<numbers.Length; i++)
        {
            numbers[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Duplicate numbers are");
        for(int i=0;i<numbers.Length; i++)
        {
            bool isRepeat = false;
            for(int j=0; j<i; j++)
            {
                if(numbers[i]==numbers[j])
                {
                    isRepeat = true;
                    break;
                }
            }
            if(!isRepeat)
            {
                for(int j=i+1;j<numbers.Length; j++)
                {
                    if( numbers[i]==numbers[j])
                    {
                        Console.WriteLine(numbers[i]);
                        break;
                    }
                }
            }
        }
    }
}