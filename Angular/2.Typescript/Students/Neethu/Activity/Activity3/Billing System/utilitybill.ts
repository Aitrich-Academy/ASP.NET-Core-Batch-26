import * as readline from 'readline';

const rl=readline.createInterface({
    input:process.stdin,
    output:process.stdout

});

let running=true;
let units:number|null=null;
function Mainmenu()
{
    if(!running)
    {
        rl.close();
        return;

    }
    console.log("=========Smart Utility Billing System=========");
    console.log("1. Enter Units Consumed");
    console.log("2. Calculate Bill");
    console.log("3. Exit");
    rl.question("Enter the Option",(choice)=>{
        switch(choice)
        {
            case "1":
                rl.question("Enter units consumed: ",(u)=>{
                    const unit=Number(u);
                    if(isNaN(unit)||unit<0)
                    {
                        console.log("Invalid units. Try again.");

                    }
                    else 
                    {
                        units = unit;
                        console.log("Units saved successfully.");
                    }

                    Mainmenu();
                });
                break;
            case "2":
                if (units === null) 
                {
                    console.log("Please enter units first.");
                    break;
                }
                const baseBill = calculateBill(units);
                const taxAmount = applyTax(baseBill, (x) => x);
                const totalBill = baseBill + taxAmount;

                console.log("\n--- Bill Summary ---");
                console.log(`Units Consumed: ${units}`);
                console.log(`Base Bill: ₹${baseBill}`);
                console.log(`Tax (5%): ₹${taxAmount}`);
                console.log(`Total Bill: ₹${totalBill}`);
                Mainmenu();
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
function calculateBill(units: number): number {
    let bill = 0;

    
    if (units <= 100) {
        bill = units * 1.5;
    } 
    else if (units <= 200) {
        bill = (100 * 1.5) + ((units - 100) * 2.5);
    } 
    else {
        bill = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
    }

    return bill;
}
function applyTax(amount: number, taxFn: (x: number) => number, taxRate: number = 0.05): number {
    return taxFn(amount * taxRate);
}
Mainmenu();

