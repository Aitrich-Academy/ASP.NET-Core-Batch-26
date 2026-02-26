interface Employee{
    id:number,
    name:string,
    Department:string,
    Salary:number
}
const Employee3:Employee={
    id:1,
    name:"Sajith",
    Department:"IT",
    Salary:500000

}
const Employee4:Employee={
    id:2,
    name:"Yuva",
    Department:"Financial",
    Salary:23000

}
console.log("Employee1:\n",Employee3.id,"\n",Employee3.name,"\n",Employee3.Department,"\n",Employee3.Salary);
console.log("Employee2:\n",Employee4.id,"\n",Employee4.name,"\n",Employee4.Department,"\n",Employee4.Salary);