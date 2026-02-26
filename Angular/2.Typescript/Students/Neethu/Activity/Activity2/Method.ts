class Car{
    Brand!:string;
    Price!:number;
    constructor(brand:string,price:number)
    {
        this.Brand=brand;
        this.Price=price;
    }
    displayDetails():void{
        console.log("Brand:",this.Brand);
        console.log("Price:",this.Price);
    }
}
var Car1=new Car("Benze",10000000);
Car1.displayDetails();