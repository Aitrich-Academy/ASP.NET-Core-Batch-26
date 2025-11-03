using System;
using System.Collections.Generic;

namespace EF_Book.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }
}
