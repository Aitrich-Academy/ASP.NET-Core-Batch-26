using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Models
{
    public class Interview
    {
        public int JobId { get; set; }
        public string Company { get; set; }
        public string Jobtitle { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }

        public Interview() { }
        public Interview(int jobid,string jobtitle,string company, string location, DateTime interviewDate, string time)
        {
            Company = company;
            Jobtitle = jobtitle;
            InterviewDate = interviewDate;
            Location = location;
            Time = time;
            JobId= jobid;
        }
    }
}
