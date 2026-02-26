class Student{
    Id!:number;
    Name!:string;
    Grade!:number;
}
var student1=new Student();
var student2=new Student();
student1.Id=2;
student1.Name="Ria";
student1.Grade=6;
console.log("Student1:\n Id:",student1.Id,"\n","Name:",student1.Name,"\nGrade",student1.Grade);
student2.Id=3;
student2.Name="Jaanvi";
student2.Grade=1;
console.log(`Student2\nId:${student2.Id}\nName:${student2.Name}\nGrade:${student2.Grade}`);