using static HiriingMgmntSystem.enums.ExperienceLevelandRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiriingMgmntSystem.Model
{
    internal class Job
    {
       public int Id {  get; set; }
       public string Title {  get; set; }
       public string Company {  get; set; }
       public string Location {  get; set; }
         public string salaryRange {  get; set; }
        public string location {  get; set; }
       public string JobType {  get; set; }
        ExperienceLevel experienceLevel { get; set; }

    }
}
