class BankAccount{
    private balance!:number;
    constructor(initialbalance:number)
    {
        this.balance=initialbalance;
    }
    public Deposit(amount:number):void{
        if(amount>0)
        {
            this.balance+=amount;

        }
        else
        {
            console.log("Invalid Deposit Amount");
        }
    }
    public GetBalance():number{
       return this.balance;
    }
}
var account=new BankAccount(0);
account.Deposit(5000);
console.log("Balance:",account.GetBalance());