using System;
using System.Collections.Generic;

namespace EF_Book.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string Sname { get; set; } = null!;

    public int Smark { get; set; }
}
