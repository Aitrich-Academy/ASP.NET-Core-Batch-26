using System;
using System.Collections.Generic;

namespace Razor_Crud3.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Mark { get; set; }

    public string Grade { get; set; } = null!;
}
