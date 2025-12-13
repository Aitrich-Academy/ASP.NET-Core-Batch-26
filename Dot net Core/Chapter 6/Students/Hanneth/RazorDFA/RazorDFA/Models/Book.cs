using System;
using System.Collections.Generic;

namespace RazorDFA.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string Price { get; set; } = null!;
}
