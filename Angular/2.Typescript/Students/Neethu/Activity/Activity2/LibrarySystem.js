var Book = /** @class */ (function () {
    function Book(title, author) {
        this.title = title;
        this.author = author;
        this.isAvailable = true;
    }
    Book.prototype.borrow = function () {
        if (this.isAvailable) {
            this.isAvailable = false;
            console.log("".concat(this.title, " has been borrowed"));
        }
        else {
            console.log("".concat(this.title, " is not available"));
        }
    };
    Book.prototype.returnBook = function () {
        this.isAvailable = true;
        console.log("".concat(this.title, " has been returned"));
    };
    return Book;
}());
var Member = /** @class */ (function () {
    function Member(name) {
        this.name = name;
    }
    Member.prototype.borrowBook = function (book) {
        console.log("".concat(this.name, " is trying to borrow ").concat(book.title));
        book.borrow();
    };
    Member.prototype.returnBook = function (book) {
        console.log("".concat(this.name, " is returning ").concat(book.title));
        book.returnBook();
    };
    return Member;
}());
var book1 = new Book("The Alchemist", "Paulo Coelho");
var member1 = new Member("Ria");
member1.borrowBook(book1);
member1.returnBook(book1);
