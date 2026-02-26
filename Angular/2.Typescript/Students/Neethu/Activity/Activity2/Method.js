var Car = /** @class */ (function () {
    function Car(brand, price) {
        this.Brand = brand;
        this.Price = price;
    }
    Car.prototype.displayDetails = function () {
        console.log("Brand:", this.Brand);
        console.log("Price:", this.Price);
    };
    return Car;
}());
var Car1 = new Car("Benze", 10000000);
Car1.displayDetails();
