"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var running = true;
var units = null;
function Mainmenu() {
    if (!running) {
        rl.close();
        return;
    }
    console.log("=========Smart Utility Billing System=========");
    console.log("1. Enter Units Consumed");
    console.log("2. Calculate Bill");
    console.log("3. Exit");
    rl.question("Enter the Option", function (choice) {
        switch (choice) {
            case "1":
                rl.question("Enter units consumed: ", function (u) {
                    var unit = Number(u);
                    if (isNaN(unit) || unit < 0) {
                        console.log("Invalid units. Try again.");
                    }
                    else {
                        units = unit;
                        console.log("Units saved successfully.");
                    }
                    Mainmenu();
                });
                break;
            case "2":
                if (units === null) {
                    console.log("Please enter units first.");
                    break;
                }
                var baseBill = calculateBill(units);
                var taxAmount = applyTax(baseBill, function (x) { return x; });
                var totalBill = baseBill + taxAmount;
                console.log("\n--- Bill Summary ---");
                console.log("Units Consumed: ".concat(units));
                console.log("Base Bill: \u20B9".concat(baseBill));
                console.log("Tax (5%): \u20B9".concat(taxAmount));
                console.log("Total Bill: \u20B9".concat(totalBill));
                Mainmenu();
                break;
            case "3":
                console.log("Exiting the program...");
                running = false;
                Mainmenu();
                break;
            default:
                console.log("Invalid Choice");
                Mainmenu();
                break;
        }
    });
}
function calculateBill(units) {
    var bill = 0;
    if (units <= 100) {
        bill = units * 1.5;
    }
    else if (units <= 200) {
        bill = (100 * 1.5) + ((units - 100) * 2.5);
    }
    else {
        bill = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
    }
    return bill;
}
function applyTax(amount, taxFn, taxRate) {
    if (taxRate === void 0) { taxRate = 0.05; }
    return taxFn(amount * taxRate);
}
Mainmenu();
