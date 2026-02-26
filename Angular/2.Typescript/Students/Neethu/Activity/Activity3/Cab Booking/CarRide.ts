import * as readline from 'readline';

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

let selectedride:string|null=null;
let running=true;
let distance:number|null=null;

function Mainmenu()
{
    if(!running)
    {
        rl.close();
        return;
    }
    console.log("\n===== Cab Booking Application =====");
    console.log("1. Book Ride");
    console.log("2. Calculate Fare");
    console.log("3. Exit");
    rl.question("Enter your choice: ", (choice) => {
        switch (choice) {
            case "1":
                BookRide();
                break;

            case "2":
                CalculateFare();
                break;

            case "3":
                console.log("Exiting application...");
                running = false;
                Mainmenu();
                break;

            default:
                console.log("Invalid choice");
                Mainmenu();
        }
    });

}
function BookRide()
{
    console.log("\nChoose Vehicle Type:");
    console.log("1. Mini");
    console.log("2. Sedan");
    console.log("3. SUV");
    rl.question("Enter the vehicle Type",(vtype)=>{
        switch(vtype)
        {
            case "1":
                selectedride="Mini";
                break;
            case "2":
                selectedride="Sedan";
                break;
            case "3":
                selectedride="SUV";
                break;
            default:
                console.log("Invalid Choice");
                break;
        }
         rl.question("Enter the distance in Km to travel",(dist)=>{
        const d=Number(dist);
        if(isNaN(d)||d<=0)
        {
            console.log("Invalid distance");3
            3
                return Mainmenu();

        }
        distance=d;
        console.log(`Ride booked: ${selectedride}, Distance: ${distance} KM`);
            Mainmenu();

    });
    });
   



}
function CalculateFare(){

    if(!selectedride||distance==null)
    {
        console.log("No ride booked yet.");
        return Mainmenu();

    }
    let basefare=10;
    switch(selectedride)
    {
        case "Mini":
            basefare = 8;
            break;
        case "Sedan":
            basefare = 12;
            break;
        case "SUV":
            basefare = 15;
            break;

    }
    const totalfare=FareCalculation(basefare,distance);

    const discountedFare = applyDiscount(totalfare, (amount) => amount * 0.9);
    console.log(`\nVehicle: ${selectedride}`);
    console.log(`Distance: ${distance} KM`);
    console.log(`Base Fare per KM: ${basefare}`);
    console.log(`Total Fare (after 10% discount): ${discountedFare}`);

    Mainmenu();


}
function FareCalculation(basefare:number=10,dist:number):number{
    return basefare*dist;
}
function applyDiscount(fare: number, discountFn: (amount: number) => number): number {
    return discountFn(fare);
}

Mainmenu();
