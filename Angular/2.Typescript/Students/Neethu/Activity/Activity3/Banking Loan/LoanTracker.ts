import * as readlineSync from "readline-sync";

let running = true;
let salary: number | null = null;
let age: number | null = null;


function checkLoanEligibility(salary: number, age: number, cibilScore: number = 700): boolean {
    // Basic eligibility rules
    if (salary >= 30000 && age >= 21 && cibilScore >= 700) {
        return true;
    } else {
        return false;
    }
}

while (running) {
    console.log("\n===== Banking Loan Eligibility Checker =====");
    console.log("1. Enter Salary & Age");
    console.log("2. Check Eligibility");
    console.log("3. Exit");

    const choice = readlineSync.question("Enter your choice: ");

    switch (choice) {
        case "1":
            const s = Number(readlineSync.question("Enter your monthly salary: "));
            const a = Number(readlineSync.question("Enter your age: "));

            if (isNaN(s) || s <= 0 || isNaN(a) || a <= 0) {
                console.log("Invalid input. Please enter valid numbers.");
            } else {
                salary = s;
                age = a;
                console.log("Details saved successfully.");
            }
            break;

        case "2":
            if (salary === null || age === null) {
                console.log("Please enter salary and age first.");
                break;
            }

            
            const eligible = checkLoanEligibility(salary, age);

            console.log("\n--- Eligibility Result ---");
            console.log(`Salary: ${salary}`);
            console.log(`Age: ${age}`);

            if (eligible) {
                console.log("You are eligible for the loan.");
            } else {
                console.log("You are NOT eligible for the loan.");
            }
            break;

        case "3":
            console.log("Exiting...");
            running = false;
            break;

        default:
            console.log("Invalid choice");
    }
}