using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HiringManagementSystem.enums.ExperienceLevelandRoles;

namespace HiringManagementSystem.Models
{
    internal class Job
    {
       public int Id { get; set; }
        public string Title {  get; set; }
      public  ExperienceLevel ExperienceLevel {  get; set; }
     public string Company {  get; set; }
      public string Location {  get; set; }
     public string SalaryRange {  get; set; }
      public string JobType{  get; set; }
      
    }
}
