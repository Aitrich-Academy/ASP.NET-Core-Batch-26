"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var running = true;
function Mainmenu() {
    if (!running) {
        rl.close();
        return;
    }
    console.log("=========Number Utility Console Tool=========");
    console.log("1. Check Prime");
    console.log("2. Check Even/Odd");
    console.log("3. Exit");
    rl.question("Enter the choice", function (choice) {
        switch (choice) {
            case "1":
                rl.question("Enter a number", function (num) {
                    var n = Number(num);
                    checkPrime(n);
                });
                break;
            case "2":
                rl.question("Enter a number", function (num) {
                    var d = Number(num);
                    CheckEvenOrOdd(d);
                });
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
function checkPrime(num) {
    if (num < 2) {
        console.log("It's not a Prime Number");
    }
    else if (num == 2) {
        console.log("It's a Prime Number");
    }
    else {
        var isPrime = true;
        for (var i = 2; i <= Math.sqrt(num); i++) {
            if (num % i == 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            console.log("This is a Prime Number");
        }
        else {
            console.log("This is not a Prime Number");
        }
    }
    Mainmenu();
}
function CheckEvenOrOdd(num) {
    if (num == 0) {
        console.log("Enter a number greater than 0");
    }
    else if (num % 2 == 0) {
        console.log("This is an Even Number");
    }
    else {
        console.log("This is  an Odd Number");
    }
    Mainmenu();
}
Mainmenu();
