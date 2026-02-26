import * as readline from 'readline';
import { Employee } from './Employee';

const rl=readline.createInterface({
    input:process.stdin,
    output:process.stdout


});

let employees:Employee[]=[];
let running=true;

function Mainmenu(){
    if(!running)
    {
        rl.close();
        return;
    }
    console.log("===== Employee Salary Processing =====");
    console.log("1. Add Employee");
    console.log("2. Calculate Salary");
    console.log("3. Exit");
    rl.question("Enter Your Choice:",(choice)=>{
        switch(choice)
        {
            case "1":
                AddEmployee();
                break;
            case "2":
                CalculateSalary();
                break;
            case "3":
                console.log("Exiting from the Salary Processor");
                running=false;
                Mainmenu();
                break;


        }
    });
}
function AddEmployee():void{
    rl.question("Enter Employee name",(ename)=>
    {
        rl.question("Enter Employee's Basic Salary",(basic)=>{
            const basesal=Number(basic);
            rl.question("Enter bonus(Optional:Press Enter Key to skip)",(ebonus)=>{
                let bonus:number|undefined;
                if(ebonus.trim()!="")
                {
                    bonus=Number(ebonus);
                }
                const emp= new Employee(ename,basesal,bonus);
                employees.push(emp);
                console.log(`Employee ${ename} added successfully.\n`);
                Mainmenu();
            });
        });

    });
    
}
function CalculateSalary():void{
    if(employees.length==0)
    {
        console.log("No employees Found");
        return;
    }
    console.log("Employee List\n");
   employees.forEach((emp,index)=>{
        console.log(`${index+1}. ${emp.Name}`)
   });
   rl.question("Select the employee number you wish to calculate salary:",(num)=>{
        const index=Number(num)-1;
        const emp=employees[index];
        if(!emp)
        {
            console.log("Invalid employee selection");
            return;
        }
        let bonus=0;
        if(emp.Bonus!=undefined)
        {
            bonus=emp.Bonus;
        }
        else
        {
            console.log("No bonus entered earlier. Default bonus = 0.");
        }
        const Totalsalary=emp.BasicSalary+bonus;
        console.log(`${emp.Name}'s Total Salary is ${Totalsalary}`);

        Mainmenu();
   });
}
Mainmenu();