import * as readline from 'readline';

const rl=readline.createInterface({
    input:process.stdin,
    output:process.stdout

});

const Marks:number[]=[];
let running=true;

function Mainmenu(){
    if(!running)
    {
        rl.close();
        return;
    }
    console.log("\n===== Online Exam Result System =====");
    console.log("1. Enter Marks");
    console.log("2. View Grade");
    console.log("3. Exit");

    rl.question("Enter your Coice",(choice)=>{
        switch(choice)
        {
            case "1":
                AddMark();
                break;
            case "2":
                ViewGrade();
                break;
            case "3":
                console.log("Exiting the program..");
                running=false;
                Mainmenu();
                break;
        }
    });

}
function AddMark(){
    rl.question("Please enter the mark between 0 to 100",(mark)=>{
        const newmark=Number(mark);
        if(isNaN(newmark)||newmark<0||newmark>100)
        {
            console.log("Enter a Valid Mark");
            return Mainmenu();
        }
        Marks.push(newmark);
        console.log("Mark added successfully");
        Mainmenu();
    });
}
function ViewGrade(){
    if(Marks.length==0)
    {
        console.log("No Marks in the list to show ");
        return;
    }
    Marks.forEach((score,index)=>
    {
       let grade = "";

        if (score >= 90) grade = "A+";
        else if (score >= 80) grade = "A";
        else if (score >= 70) grade = "B";
        else if (score >= 60) grade = "C";
         else if (score >= 50) grade = "D";
        else grade = "Fail";
        
        console.log(`${score}--${grade}`);

    });
    Mainmenu();

}
Mainmenu();