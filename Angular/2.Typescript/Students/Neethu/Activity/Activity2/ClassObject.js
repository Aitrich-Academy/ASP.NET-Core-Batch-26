var Student = /** @class */ (function () {
    function Student() {
    }
    return Student;
}());
var student1 = new Student();
var student2 = new Student();
student1.Id = 2;
student1.Name = "Ria";
student1.Grade = 6;
console.log("Student1:\n Id:", student1.Id, "\n", "Name:", student1.Name, "\nGrade", student1.Grade);
student2.Id = 3;
student2.Name = "Jaanvi";
student2.Grade = 1;
console.log("Student2\nId:".concat(student2.Id, "\nName:").concat(student2.Name, "\nGrade:").concat(student2.Grade));
