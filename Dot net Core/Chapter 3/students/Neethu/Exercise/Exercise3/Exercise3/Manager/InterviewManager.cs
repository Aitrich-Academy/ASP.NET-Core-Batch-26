using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Manager
{
    public class InterviewManager
    {
        public InterviewManager() { }
        List<Interview> interviews = new List<Interview>();
        public void ScheduleInterview(Interview interview)
        {
            interviews.Add(interview);
        }
        public void ListInterviews()
        {
            if(interviews!=null)
                Console.WriteLine("Interviews \n");
            Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}", "JobId", "Designation", "Company", "Location/online", "Date", "Time");
            {
                foreach(Interview interview in interviews)
                {

                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}", interview.JobId,interview.Jobtitle,interview.Company,interview.Location,interview.InterviewDate,interview.Time);

                }
            }
        }
    }
}
