
namespace SimpleBankManagement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Number:");
            string accnumber=Console.ReadLine();
            Console.WriteLine("Enter Account Holder Name");
            string accname=Console.ReadLine();
            Console.WriteLine("Enter Initial Balance");
            decimal initialbalance=Decimal.Parse(Console.ReadLine());

            Account account=new Account(accnumber, accname,initialbalance);

            Console.WriteLine("\n Account Details");
            Console.WriteLine("Account Number:" + account.AccountNumber);
            Console.WriteLine("Account Holder Name:" + account.AccountHoldername);
            Console.WriteLine("Balance:$" + account.Balance);


            Console.WriteLine("\nEnter Amount to Deposit:");
            decimal depositamnt=Decimal.Parse(Console.ReadLine());
            account.Deposit(depositamnt);
            Console.WriteLine("Successfully deposited$" + depositamnt);
            Console.Write(".New balance:$"+account.Balance);

            Console.WriteLine("\nEnter Amount to Withdraw:");
            decimal withdrawamnt=Decimal.Parse(Console.ReadLine());
            account.Withdraw(withdrawamnt);
            Console.WriteLine("Successfully withdrew$" + withdrawamnt);
            Console.Write(".New balance:$" + account.Balance);

        }
    }
}
