using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFA_Employee.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Salary { get; set; }

        public Employee(string name,string salary)
        {
            
            Name = name;
            Salary = salary;
        }
    }
}
