interface Shape{
    draw():void;
}
class Circle implements Shape{
    draw(): void {
        console.log("Drawing a Circle");
    }
}
class Rectangle implements Shape{
    draw(): void {
        console.log("Drawing a Rectangle");
    }
}
var circle1=new Circle();
var rect=new Rectangle();
circle1.draw();
rect.draw();
