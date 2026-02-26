"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var selectedride = null;
var running = true;
var distance = null;
function Mainmenu() {
    if (!running) {
        rl.close();
        return;
    }
    console.log("\n===== Cab Booking Application =====");
    console.log("1. Book Ride");
    console.log("2. Calculate Fare");
    console.log("3. Exit");
    rl.question("Enter your choice: ", function (choice) {
        switch (choice) {
            case "1":
                BookRide();
                break;
            case "2":
                CalculateFare();
                break;
            case "3":
                console.log("Exiting application...");
                running = false;
                Mainmenu();
                break;
            default:
                console.log("Invalid choice");
                Mainmenu();
        }
    });
}
function BookRide() {
    console.log("\nChoose Vehicle Type:");
    console.log("1. Mini");
    console.log("2. Sedan");
    console.log("3. SUV");
    rl.question("Enter the vehicle Type", function (vtype) {
        switch (vtype) {
            case "1":
                selectedride = "Mini";
                break;
            case "2":
                selectedride = "Sedan";
                break;
            case "3":
                selectedride = "SUV";
                break;
            default:
                console.log("Invalid Choice");
                break;
        }
        rl.question("Enter the distance in Km to travel", function (dist) {
            var d = Number(dist);
            if (isNaN(d) || d <= 0) {
                console.log("Invalid distance");
                return Mainmenu();
            }
            distance = d;
            console.log("Ride booked: ".concat(selectedride, ", Distance: ").concat(distance, " KM"));
            Mainmenu();
        });
    });
}
function CalculateFare() {
    if (!selectedride || distance == null) {
        console.log("No ride booked yet.");
        return Mainmenu();
    }
    var basefare = 10;
    switch (selectedride) {
        case "Mini":
            basefare = 8;
            break;
        case "Sedan":
            basefare = 12;
            break;
        case "SUV":
            basefare = 15;
            break;
    }
    var totalfare = FareCalculation(basefare, distance);
    var discountedFare = applyDiscount(totalfare, function (amount) { return amount * 0.9; });
    console.log("\nVehicle: ".concat(selectedride));
    console.log("Distance: ".concat(distance, " KM"));
    console.log("Base Fare per KM: ".concat(basefare));
    console.log("Total Fare (after 10% discount): ".concat(discountedFare));
    Mainmenu();
}
function FareCalculation(basefare, dist) {
    if (basefare === void 0) { basefare = 10; }
    return basefare * dist;
}
function applyDiscount(fare, discountFn) {
    return discountFn(fare);
}
Mainmenu();
