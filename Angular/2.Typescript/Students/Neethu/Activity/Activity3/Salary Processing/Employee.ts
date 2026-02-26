export class Employee{
    Name!:string;
    BasicSalary!:number;
    Bonus?:number;

    constructor(name:string,basicsalary:number,bonus?:number)
    {
        this.Name=name;
        this.BasicSalary=basicsalary;
        this.Bonus=bonus;
    }
}