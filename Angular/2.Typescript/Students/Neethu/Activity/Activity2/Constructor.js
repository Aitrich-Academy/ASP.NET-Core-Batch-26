var Employee = /** @class */ (function () {
    function Employee(id, name, salary) {
        this.Id = id;
        this.Nmae = name;
        this.Salary = salary;
    }
    return Employee;
}());
var Employee1 = new Employee(1, "Sita", 50000);
console.log(Employee1);
