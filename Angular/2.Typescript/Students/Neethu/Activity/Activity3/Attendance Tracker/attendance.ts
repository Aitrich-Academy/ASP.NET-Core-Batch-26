import * as readlineSync from "readline-sync";

let totalclass=0;
let attendedclass=0;
let running=true;
while(running)
{
    console.log("\n===== Student Attendance Tracker =====");
    console.log("1. Mark Attendance");
    console.log("2. View Attendance Percentage");
    console.log("3. Exit");
    const choice=readlineSync.question("Enter your choice");
    switch(choice)
    {
        case "1":
            console.log("\n1. Present");
            console.log("2. Absent");
            const status=readlineSync.question("Enter the option");
            const attendance=Number(status);
            totalclass++;
            if(attendance==1)
            {
                attendedclass++;
                console.log("Marked Present");

            }
            else if(attendance==2)
            {
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
            const percentage=(attendedclass/totalclass)*100;
            console.log(`\nTotal Classes: ${totalclass}`);
            console.log(`Attended: ${attendedclass}`);
            console.log(`Attendance Percentage: ${percentage}`);

            if (percentage >= 90) console.log("Excellent attendance");
            else if (percentage >= 75) console.log("Good attendance");
            else if (percentage >= 50) console.log("Needs improvement");
            else console.log("Poor attendance");

            break;
        case "3":
             console.log("Exiting...");
            running = false;
            break;

        default:
            console.log("Invalid choice");


        


    }
}