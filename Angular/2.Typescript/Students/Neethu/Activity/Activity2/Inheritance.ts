class Person{
    Name!:string;
    Age!:number;
    constructor(name:string,age:number)
    {
        this.Name=name;
        this.Age=age;
    }

}
class Teacher extends Person{
Subject!:string;
constructor(Name:string,Age:number,subject:string)
{
    super(Name,Age);
    this.Subject=subject;

}
}
var Teacher1=new Teacher("Maya",32,"Maths");
console.log(`Teacher Details:
Name: ${Teacher1.Name}
Age: ${Teacher1.Age}
Subject: ${Teacher1.Subject}`);

 