using Library_Management_System;

internal class Program
{
     static void Main(string[] args)
    {
        LibraryItem[] libraryItems = new LibraryItem[6];
        libraryItems[0] = new Book("001", "Book1", true, "Author1");
        libraryItems[1] = new Book("002", "Book2", true, "Author2");
        libraryItems[2] = new Book("003", "Book3", true, "Author3");
        libraryItems[3] = new DVD("004", "DVD1", true, 2);
        libraryItems[4] = new DVD("005", "DVD2", true, 3);
        libraryItems[5] = new DVD("006", "DVD3", true, 2);

        libraryItems[0].BorrowItem();
        libraryItems[2].BorrowItem();

        libraryItems[3].BorrowItem();
        libraryItems[4].BorrowItem();

        libraryItems[2].ReturnItem();
        libraryItems[4].ReturnItem();

        Console.WriteLine("List of Item's available in the Library");
        foreach (LibraryItem item in libraryItems)
        {
            Console.WriteLine($"Item ID: {item.ItemId} Type: {item.GetItemType(item)} Availability: {item.IsAvailable}");
        }
    }
}