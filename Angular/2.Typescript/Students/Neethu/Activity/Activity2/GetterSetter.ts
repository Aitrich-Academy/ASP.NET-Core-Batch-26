class Product{
    private price!:number;
    constructor(price:number)
    {
        this.price=price;
    }
    public get Price():number{
        return this.price;
    }
    public set Price(amount:number)
    {
        if(amount>0)
            this.price=amount;
        else
            console.log("Invalid Price");
    }
}
var product1=new Product(20);
product1.Price=150;
console.log(`Product Price: ${product1.Price}`);
