internal class Program
{
    struct Account
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;
    }
    private static void Main(string[] args)
    {
        Account[] accounts = new Account[3];
        for (int i = 0; i < accounts.Length; i++)
        {
            Console.WriteLine("Enter the Account number");
            accounts[i].AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee name");
            accounts[i].HolderName = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            accounts[i].Balance = Convert.ToDouble(Console.ReadLine());

        }
        Console.WriteLine("Enter the account number for which the details to be printed");
        int searchID=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<accounts.Length;i++)
        {
            if(accounts[i].AccountNumber == searchID)
            {
                Console.WriteLine("Account Number: " + accounts[i].AccountNumber);
                Console.WriteLine("Holder Name: "+accounts[i].HolderName);
                Console.WriteLine("Balance: " + accounts[i].Balance);
            }
        }
    }
}