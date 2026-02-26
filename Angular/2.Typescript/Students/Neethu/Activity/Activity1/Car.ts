class Car{
    private brand:string;
    private model:string;
    private price:number;

    public constructor(Brand:string,Model:string,Price:number)
    {
        this.brand=Brand;
        this.model=Model;
        this.price=Price;
    }
}
const Car1:Car=new Car("Figo","SUV",15000000);
const Car2:Car=new Car("Thar","Jeep",2500000);
console.log(Car1);
console.log(Car2);