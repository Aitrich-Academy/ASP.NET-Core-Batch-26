using EF_Book.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new CfaContext())
        {
            bool exitprogram = false;
            string ch;
            while (!exitprogram)
            {
                Console.WriteLine("1.Register Book");
                Console.WriteLine("2. Display Book details");
                Console.WriteLine("3. Update details");
                Console.WriteLine("4. Delete detals");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose any Option");
                ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        Console.WriteLine("Please Enter the name of the Book");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please Enter the Price");
                        int Price = Convert.ToInt32(Console.ReadLine());
                        Book newBook = new Book(name, Price);
                        context.Books.Add(newBook);
                        context.SaveChanges();
                        Console.WriteLine("New Product got added");
                        break;
                    case "2":
                        Console.WriteLine("Employee Details");
                        var Allbooks = context.Books.ToList();
                        foreach (var book in Allbooks)
                        {
                            Console.WriteLine($"Id:{book.Id}----Name:{book.Name}-----Price:{book.Price}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter the BookId you want to update");
                        int id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the new Book name");
                        string Bookname=Console.ReadLine();
                        Console.WriteLine("Enter the new price for the book");
                        int bookprice=Convert.ToInt32(Console.ReadLine());
                        var BID=context.Books.FirstOrDefault(b=>b.Id==id);
                        if(BID!=null)
                        {
                            BID.Name = Bookname;
                            BID.Price = bookprice;
                            context.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Requested book could not be found");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter the bookid you wish to delete");
                        int id2=Convert.ToInt32(Console.ReadLine());
                        var BID2 = context.Books.FirstOrDefault(b => b.Id == id2);
                        if(BID2!=null)
                        {
                            context.Books.Remove(BID2);
                            context.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Requested book could not be found");
                        }
                        break;
                    case "5":
                                exitprogram = true;
                                break;
                            default:
                                Console.WriteLine("Invalid Option");
                                break;


                            }

            }


        }   
    }
}