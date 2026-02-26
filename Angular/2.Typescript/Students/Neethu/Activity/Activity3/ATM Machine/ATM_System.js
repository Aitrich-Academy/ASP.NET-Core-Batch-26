"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
function showMenu() {
    console.log('*****ATM Machine*****');
    console.log('1. Check Balance');
    console.log('2. Deposit Money');
    console.log('3. Withdraw Money');
    console.log('4. Exit');
}
var balance = 0;
var exitprogram = false;
function Mainmenu() {
    if (exitprogram) {
        rl.close();
        return;
    }
    showMenu();
    rl.question("Choose an option", function (choice) {
        switch (choice) {
            case "1":
                console.log("Your Balance is ".concat(balance));
                Mainmenu();
                break;
            case "2":
                Deposit();
                break;
            case "3":
                Withdraw();
                break;
            case "4":
                console.log("Exiting The ATM Program...");
                exitprogram = true;
                Mainmenu();
                break;
            default:
                console.log("Invalid Choice");
                break;
        }
    });
}
function Deposit() {
    rl.question("Enter the amount to be Deposited", function (amnt) {
        var amount = Number(amnt);
        if (amount < 0) {
            console.log("Invalid amount");
        }
        else {
            balance += amount;
            console.log("Deposited Amount".concat(amount));
        }
        Mainmenu();
    });
}
function Withdraw() {
    rl.question("Enter the amount to be Withdrawed", function (amnt) {
        var debit = Number(amnt);
        if (debit > balance) {
            console.log("Balance too low to debit the amount.Please enter a new amount");
        }
        else {
            balance -= debit;
            console.log("Withdrawed Amount".concat(debit));
        }
        Mainmenu();
    });
}
Mainmenu();
