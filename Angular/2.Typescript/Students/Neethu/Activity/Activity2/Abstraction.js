var Circle = /** @class */ (function () {
    function Circle() {
    }
    Circle.prototype.draw = function () {
        console.log("Drawing a Circle");
    };
    return Circle;
}());
var Rectangle = /** @class */ (function () {
    function Rectangle() {
    }
    Rectangle.prototype.draw = function () {
        console.log("Drawing a Rectangle");
    };
    return Rectangle;
}());
var circle1 = new Circle();
var rect = new Rectangle();
circle1.draw();
rect.draw();
