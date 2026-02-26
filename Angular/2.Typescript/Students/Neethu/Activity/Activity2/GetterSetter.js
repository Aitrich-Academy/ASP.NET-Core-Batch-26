var Product = /** @class */ (function () {
    function Product(price) {
        this.price = price;
    }
    Object.defineProperty(Product.prototype, "Price", {
        get: function () {
            return this.price;
        },
        set: function (amount) {
            if (amount > 0)
                this.price = amount;
            else
                console.log("Invalid Price");
        },
        enumerable: false,
        configurable: true
    });
    return Product;
}());
var product1 = new Product(20);
product1.Price = 150;
console.log("Product Price: ".concat(product1.Price));
