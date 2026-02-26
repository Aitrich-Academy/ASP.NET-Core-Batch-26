import { mainModule } from 'process';
import * as readline from 'readline';
import { RetryAgent } from 'undici-types';

const rl=readline.createInterface({
    input:process.stdin,
    output:process.stdout

});

let running=true;
function Mainmenu()
{
    if(!running)
    {
        rl.close();
        return;

    }
    console.log("=========Number Utility Console Tool=========");
    console.log("1. Check Prime");
    console.log("2. Check Even/Odd");
    console.log("3. Exit");
    rl.question("Enter the choice",(choice)=>{
        switch(choice)
        {
            case "1":
                rl.question("Enter a number",(num)=>{
                    const n=Number(num);
                    checkPrime(n);
                    
                })
                break;
            case "2":
                rl.question("Enter a number",(num)=>{
                    const d=Number(num);
                    CheckEvenOrOdd(d);
                });
                break;
            case "3":
                console.log("Exiting the program...");
                running=false;
                Mainmenu();
                break;
            default:
                console.log("Invalid Choice");
                Mainmenu();
                break;
        }
    });


}
function checkPrime(num:number):void{
    if(num<2)
    {
        console.log("It's not a Prime Number");
    }
    else if(num==2)
    {
        console.log("It's a Prime Number");
    }
    else
    {
        var isPrime:Boolean=true;
        
        
        for(let i=2;i<=Math.sqrt(num);i++)
        {
            if(num%i==0)
            {
                isPrime=false;
                break;

            }
        }
        if (isPrime)
        {
             console.log("This is a Prime Number");
        }
        else
        {
             console.log("This is not a Prime Number");
        }
    }
    Mainmenu();
}
function CheckEvenOrOdd(num:number):void{
    if(num==0)
    {
        console.log("Enter a number greater than 0");
    }
    else if(num%2==0)
    {
        console.log("This is an Even Number");
    }
    else{
         console.log("This is  an Odd Number");
    }
    Mainmenu();
}
Mainmenu();