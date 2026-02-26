var BankAccount = /** @class */ (function () {
    function BankAccount(initialbalance) {
        this.balance = initialbalance;
    }
    BankAccount.prototype.Deposit = function (amount) {
        if (amount > 0) {
            this.balance += amount;
        }
        else {
            console.log("Invalid Deposit Amount");
        }
    };
    BankAccount.prototype.GetBalance = function () {
        return this.balance;
    };
    return BankAccount;
}());
var account = new BankAccount(0);
account.Deposit(5000);
console.log("Balance:", account.GetBalance());
