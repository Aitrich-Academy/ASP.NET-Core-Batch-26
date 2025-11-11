using System;
using System.Collections.Generic;

namespace Razor_Crud3.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }
}
