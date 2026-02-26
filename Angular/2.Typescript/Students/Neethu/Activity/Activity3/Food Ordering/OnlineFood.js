"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline-sync");
var menu = {
    "Burger": 120,
    "Pizza": 250,
    "Pasta": 180,
    "Fries": 90,
    "Coke": 50
};
var running = true;
//Rest Parameter
var cart = [];
function showMenu() {
    console.log("-------FOOD MENU-------\n");
    var index = 1;
    for (var item in menu) {
        console.log("".concat(index, ". ").concat(item, "-").concat(menu[item]));
        index++;
    }
}
//Anonymous Function
var calculateBill = function () {
    var items = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        items[_i] = arguments[_i];
    }
    var total = 0;
    for (var _a = 0, items_1 = items; _a < items_1.length; _a++) {
        var item = items_1[_a];
        total += menu[item];
    }
    return total;
};
function AddToCart(item) {
    if (menu[item]) {
        cart.push(item);
        console.log("Item ".concat(item, " successfully added to the cart"));
    }
    else {
        console.log("Item not Found");
    }
}
while (running) {
    console.log("Online Food Order");
    console.log("1. Show Menu");
    console.log("2. Add Item To the Cart");
    console.log("3. Show the Total Bill");
    console.log("4. Exit");
    var choice = readline.question("Enter the Choice");
    switch (choice) {
        case "1":
            showMenu();
            break;
        case "2":
            var product = readline.question("Enter the item name to be added to the cart");
            AddToCart(product);
            break;
        case "3":
            if (cart.length == 0) {
                console.log("Your Cart is empty");
            }
            else {
                var total = calculateBill.apply(void 0, cart);
                console.log("Your Cart".concat(cart.join(", ")));
                console.log("Total Bill is: ".concat(total));
            }
            break;
        case "4":
            console.log("Thank you for ordering. Goodbye!");
            running = false;
            break;
        default:
            console.log("Invalid Choice");
            break;
    }
}
