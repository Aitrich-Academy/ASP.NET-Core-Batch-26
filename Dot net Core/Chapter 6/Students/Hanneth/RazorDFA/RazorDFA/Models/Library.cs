using System;
using System.Collections.Generic;

namespace RazorDFA.Models;

public partial class Library
{
    public int Lid { get; set; }

    public string Name { get; set; } = null!;

    public int NumberofBooks { get; set; }
}
