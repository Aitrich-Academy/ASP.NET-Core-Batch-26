
import * as readline from 'readline'

const rl=readline.createInterface({
    input:process.stdin,
    output:process.stdout

});

function showMenu():void{
    console.log('*****ATM Machine*****');
    console.log('1. Check Balance');
    console.log('2. Deposit Money');
    console.log('3. Withdraw Money');
    console.log('4. Exit');
}

let balance=0;
let exitprogram=false;
function Mainmenu(){
    if (exitprogram)
    {
        rl.close();
        return;
    }


    showMenu();
    rl.question("Choose an option",(choice)=>{
        switch(choice){
            case "1":console.log(`Your Balance is ${balance}` );
                    Mainmenu();
                    break;
            case "2":Deposit();
                    break;
            case "3":Withdraw();
                    break;
            case "4":console.log("Exiting The ATM Program...");
                    exitprogram=true;
                    Mainmenu();
                    break;
            default:console.log("Invalid Choice");
                    break;
        }
    });
} 


function Deposit():void{
    rl.question("Enter the amount to be Deposited",(amnt)=>{
        const amount=Number(amnt);
        if(amount<0)
        {
            console.log("Invalid amount");
        }
        else
        {
            balance+=amount;
            console.log(`Deposited Amount${amount}`);
        }
        Mainmenu();   
    });
}
function Withdraw():void{
    rl.question("Enter the amount to be Withdrawed",(amnt)=>{
        const debit=Number(amnt);
        if(debit>balance)
        {
            console.log("Balance too low to debit the amount.Please enter a new amount");
        }
        else
        {
            balance-=debit;
            console.log(`Withdrawed Amount${debit}`);
        }
        Mainmenu();
    });
}
Mainmenu();
