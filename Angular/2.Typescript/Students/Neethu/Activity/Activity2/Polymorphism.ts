class Animal
{
    makeSound():void{
        console.log("Animal Makes Sound");
    }
}
class Dog extends Animal{
    makeSound(): void {
         console.log("Dog Barks: Woof!");
    }
}
class Cat extends Animal{
    makeSound(): void {
        console.log("Cat Meows: Meow!");
    }
}
var Dog1=new Dog();
var Cat1=new Cat();
Dog1.makeSound();
Cat1.makeSound();