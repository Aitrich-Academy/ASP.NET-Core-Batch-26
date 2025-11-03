using System;
using System.Collections.Generic;

namespace EF_Book.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public Book( string name, int price)
    {
        Name = name;
        Price = price;
    }
}
