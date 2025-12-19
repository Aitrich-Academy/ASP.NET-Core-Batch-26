using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement_Repo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Designation {  get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
