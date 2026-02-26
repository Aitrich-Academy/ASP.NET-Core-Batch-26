var Car = /** @class */ (function () {
    function Car(Brand, Model, Price) {
        this.brand = Brand;
        this.model = Model;
        this.price = Price;
    }
    return Car;
}());
var Car1 = new Car("Figo", "SUV", 15000000);
var Car2 = new Car("Thar", "Jeep", 2500000);
console.log(Car1);
console.log(Car2);
