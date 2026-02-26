import * as readline from "readline";

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

let running=true;
let productprice:number|null=null;

function Mainmenu()
{
    if (!running) {
        rl.close();
        return;
    }
    console.log("\n===== E-Commerce Discount System =====");
    console.log("1. Add Product Price");
    console.log("2. Apply Discount");
    console.log("3. Exit");
    rl.question("Enter your choice",(choice)=>
    {
        switch(choice)
        {
            case "1":
                AddPrice();
                break;

            case "2":
                ApplyDiscountMenu();
                break;

            case "3":
                console.log("Exiting system...");
                running = false;
                Mainmenu();
                break;

            default:
                console.log("Invalid choice");
                Mainmenu();

        }

    });



}
function AddPrice()
{
    rl.question("Enter the product price",(price)=>
    {
        const p=Number(price);
        if(isNaN(p)||p<=0)
        {
            console.log("Invalid price");
            return Mainmenu();

        }
        productprice=p;
        console.log(`${productprice } added Successfully`);
        Mainmenu();

    });
}
function ApplyDiscountMenu(){
    if(productprice==null)
    {
        console.log("No product price added yet.");
        return Mainmenu();

    }
    console.log("\nChoose Discount Type:");
    console.log("1. 10% Off");
    console.log("2. 20% Off");
    console.log("3. Buy 1 Get 1 (50% Off)");
    console.log("4. No Discount");

    rl.question("Choose the discount type",(choice)=>{
        let finalprice=productprice!;
        switch(choice)
        {
            case "1":
                finalprice=applyDiscount(productprice!,(p)=>p*0.9);
                break;
            case "2":
                finalprice=applyDiscount(productprice!,(p)=>p*0.8);
                break;
            case "3":
                finalprice=applyDiscount(productprice!,(p)=>p*0.5);
                break;
            case "4":
                console.log(" No discount added");
                return Mainmenu();
                break;
            default:
                console.log("InvalId Choice ");
                return Mainmenu();
                break;

        }
        console.log(`Original Price: ${productprice}`);
        console.log(`Final Price after discount: ${finalprice}`);

        Mainmenu();

    });

}
function applyDiscount(price:number,discountfn:(p:number)=>number):number{
    return discountfn(price);
}
Mainmenu();