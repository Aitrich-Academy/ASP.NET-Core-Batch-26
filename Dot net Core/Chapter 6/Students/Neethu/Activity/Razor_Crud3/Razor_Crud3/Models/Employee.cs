using System;
using System.Collections.Generic;

namespace Razor_Crud3.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public decimal Salary { get; set; }
}
