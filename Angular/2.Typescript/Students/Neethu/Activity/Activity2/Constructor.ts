class Employee{
    Id!:number;
    Nmae!:string;
    Salary!:number;
    constructor(id:number,name:string,salary:number)
    {
        this.Id=id;
        this.Nmae=name;
        this.Salary=salary;
    }
}
var Employee1=new Employee(1,"Sita",50000);
console.log(Employee1);