"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var Employee_1 = require("./Employee");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var employees = [];
var running = true;
function Mainmenu() {
    if (!running) {
        rl.close();
        return;
    }
    console.log("===== Employee Salary Processing =====");
    console.log("1. Add Employee");
    console.log("2. Calculate Salary");
    console.log("3. Exit");
    rl.question("Enter Your Choice:", function (choice) {
        switch (choice) {
            case "1":
                AddEmployee();
                break;
            case "2":
                CalculateSalary();
                break;
            case "3":
                console.log("Exiting from the Salary Processor");
                running = false;
                Mainmenu();
                break;
        }
    });
}
function AddEmployee() {
    rl.question("Enter Employee name", function (ename) {
        rl.question("Enter Employee's Basic Salary", function (basic) {
            var basesal = Number(basic);
            rl.question("Enter bonus(Optional:Press Enter Key to skip)", function (ebonus) {
                var bonus;
                if (ebonus.trim() != "") {
                    bonus = Number(ebonus);
                }
                var emp = new Employee_1.Employee(ename, basesal, bonus);
                employees.push(emp);
                console.log("Employee ".concat(ename, " added successfully.\n"));
                Mainmenu();
            });
        });
    });
}
function CalculateSalary() {
    if (employees.length == 0) {
        console.log("No employees Found");
        return;
    }
    console.log("Employee List\n");
    employees.forEach(function (emp, index) {
        console.log("".concat(index + 1, ". ").concat(emp.Name));
    });
    rl.question("Select the employee number you wish to calculate salary:", function (num) {
        var index = Number(num) - 1;
        var emp = employees[index];
        if (!emp) {
            console.log("Invalid employee selection");
            return;
        }
        var bonus = 0;
        if (emp.Bonus != undefined) {
            bonus = emp.Bonus;
        }
        else {
            console.log("No bonus entered earlier. Default bonus = 0.");
        }
        var Totalsalary = emp.BasicSalary + bonus;
        console.log("".concat(emp.Name, "'s Total Salary is ").concat(Totalsalary));
        Mainmenu();
    });
}
Mainmenu();
