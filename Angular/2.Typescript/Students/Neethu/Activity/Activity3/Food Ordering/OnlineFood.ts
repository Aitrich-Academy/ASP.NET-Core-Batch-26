import * as readline from 'readline-sync';



const menu:{[key:string]:number}={
    "Burger": 120,
    "Pizza": 250,
    "Pasta": 180,
    "Fries": 90,
    "Coke": 50

};
let running=true;
//Rest Parameter
let cart:string[]=[];
function showMenu():void{
    console.log("-------FOOD MENU-------\n");
    let index=1;
    for(let item in menu )
    {
        console.log(`${index}. ${item}-${menu[item]}`);
        index++;
    }
}
//Anonymous Function
const calculateBill=function(...items:string[]):number{
    let total=0;
    for(let item of items)
    {
        total+=menu[item];
    }
    return total;
}
function AddToCart(item:string):void{
    if(menu[item])
    {
        cart.push(item);
        console.log(`Item ${item} successfully added to the cart`);
    }
    else
    {
        console.log("Item not Found");
    }
}
while(running)
{
    console.log("Online Food Order");
    console.log("1. Show Menu");
    console.log("2. Add Item To the Cart");
    console.log("3. Show the Total Bill");
    console.log("4. Exit");
    const choice=readline.question("Enter the Choice");
    switch(choice)
    {
        case "1":
            showMenu();
            break;
        case "2":
            const product=readline.question("Enter the item name to be added to the cart");
            AddToCart(product);
            break;
        case "3":
            if(cart.length==0)
            {
                console.log("Your Cart is empty");

            }
            else
            {
                const total=calculateBill(...cart);
                console.log(`Your Cart${cart.join(", ")}`);
                console.log(`Total Bill is: ${total}`);
            }
            break;
        case "4":
            console.log("Thank you for ordering. Goodbye!");
            running = false;
            break;

        default:
            console.log("Invalid Choice");
            break;


    }
}
