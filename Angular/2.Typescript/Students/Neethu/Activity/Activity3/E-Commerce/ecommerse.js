"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var running = true;
var productprice = null;
function Mainmenu() {
    if (!running) {
        rl.close();
        return;
    }
    console.log("\n===== E-Commerce Discount System =====");
    console.log("1. Add Product Price");
    console.log("2. Apply Discount");
    console.log("3. Exit");
    rl.question("Enter your choice", function (choice) {
        switch (choice) {
            case "1":
                AddPrice();
                break;
            case "2":
                ApplyDiscountMenu();
                break;
            case "3":
                console.log("Exiting system...");
                running = false;
                Mainmenu();
                break;
            default:
                console.log("Invalid choice");
                Mainmenu();
        }
    });
}
function AddPrice() {
    rl.question("Enter the product price", function (price) {
        var p = Number(price);
        if (isNaN(p) || p <= 0) {
            console.log("Invalid price");
            return Mainmenu();
        }
        productprice = p;
        console.log("".concat(productprice, " added Successfully"));
        Mainmenu();
    });
}
function ApplyDiscountMenu() {
    if (productprice == null) {
        console.log("No product price added yet.");
        return Mainmenu();
    }
    console.log("\nChoose Discount Type:");
    console.log("1. 10% Off");
    console.log("2. 20% Off");
    console.log("3. Buy 1 Get 1 (50% Off)");
    console.log("4. No Discount");
    rl.question("Choose the discount type", function (choice) {
        var finalprice = productprice;
        switch (choice) {
            case "1":
                finalprice = applyDiscount(productprice, function (p) { return p * 0.9; });
                break;
            case "2":
                finalprice = applyDiscount(productprice, function (p) { return p * 0.8; });
                break;
            case "3":
                finalprice = applyDiscount(productprice, function (p) { return p * 0.5; });
                break;
            case "4":
                console.log(" No discount added");
                return Mainmenu();
                break;
            default:
                console.log("InvalId Choice ");
                return Mainmenu();
                break;
        }
        console.log("Original Price: ".concat(productprice));
        console.log("Final Price after discount: ".concat(finalprice));
        Mainmenu();
    });
}
function applyDiscount(price, discountfn) {
    return discountfn(price);
}
Mainmenu();
