var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Person = /** @class */ (function () {
    function Person(name, age) {
        this.Name = name;
        this.Age = age;
    }
    return Person;
}());
var Teacher = /** @class */ (function (_super) {
    __extends(Teacher, _super);
    function Teacher(Name, Age, subject) {
        var _this = _super.call(this, Name, Age) || this;
        _this.Subject = subject;
        return _this;
    }
    return Teacher;
}(Person));
var Teacher1 = new Teacher("Maya", 32, "Maths");
console.log("Teacher Details:\nName: ".concat(Teacher1.Name, "\nAge: ").concat(Teacher1.Age, "\nSubject: ").concat(Teacher1.Subject));
