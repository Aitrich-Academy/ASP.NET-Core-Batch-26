
class Book {
  title: string;
  author: string;
  isAvailable: boolean;

  constructor(title: string, author: string) {
    this.title = title;
    this.author = author;
    this.isAvailable = true;
  }

  borrow(): void {
    if (this.isAvailable) {
      this.isAvailable = false;
      console.log(`${this.title} has been borrowed`);
    }
     else {
      console.log(`${this.title} is not available`);
    }
  }

  returnBook(): void {
    this.isAvailable = true;
    console.log(`${this.title} has been returned`);
  }
}


class Member {
  name: string;

  constructor(name: string) {
    this.name = name;
  }

  borrowBook(book: Book): void {
    console.log(`${this.name} is trying to borrow ${book.title}`);
    book.borrow();
  }

  returnBook(book: Book): void {
    console.log(`${this.name} is returning ${book.title}`);
    book.returnBook();
  }
}


const book1 = new Book("The Alchemist", "Paulo Coelho");
const member1 = new Member("Ria");


member1.borrowBook(book1);
member1.returnBook(book1);