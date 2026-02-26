"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readlineSync = require("readline-sync");
var totalclass = 0;
var attendedclass = 0;
var running = true;
while (running) {
    console.log("\n===== Student Attendance Tracker =====");
    console.log("1. Mark Attendance");
    console.log("2. View Attendance Percentage");
    console.log("3. Exit");
    var choice = readlineSync.question("Enter your choice");
    switch (choice) {
        case "1":
            console.log("\n1. Present");
            console.log("2. Absent");
            var status_1 = readlineSync.question("Enter the option");
            var attendance = Number(status_1);
            totalclass++;
            if (attendance == 1) {
                attendedclass++;
                console.log("Marked Present");
            }
            else if (attendance == 2) {
                console.log("Marked absent");
            }
            else {
                console.log("Invalid option. Not recorded.");
                totalclass--;
            }
            break;
        case "2":
            if (totalclass === 0) {
                console.log("No attendance records yet.");
                break;
            }
            var percentage = (attendedclass / totalclass) * 100;
            console.log("\nTotal Classes: ".concat(totalclass));
            console.log("Attended: ".concat(attendedclass));
            console.log("Attendance Percentage: ".concat(percentage));
            if (percentage >= 90)
                console.log("Excellent attendance");
            else if (percentage >= 75)
                console.log("Good attendance");
            else if (percentage >= 50)
                console.log("Needs improvement");
            else
                console.log("Poor attendance");
            break;
        case "3":
            console.log("Exiting...");
            running = false;
            break;
        default:
            console.log("Invalid choice");
    }
}
