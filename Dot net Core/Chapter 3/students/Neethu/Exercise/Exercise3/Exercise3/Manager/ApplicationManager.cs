using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise3.Manager;

namespace Exercise3.Manager
{
    public class ApplicationManager
    {
        public ApplicationManager() { }

        List<Application> applications = new List<Application> { new Application(1,"Manu","Thrissur","MBA","2 years"), new Application(2, "Alex", "Kochi", "MCA", "3 years") , new Application(3, "Ameya", "Banglore", "MTech", "1 year") };
        public void PrintApplications()
        {
            Console.WriteLine("Applications \n");
            Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}", "JobId", "Name", "Location", "Qualification",  "Experience");
            if(applications!=null)
            {
                foreach(Application app in applications)
                {
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("{0,-10}|{1,-20}|{2,-20}|{3,-20}|{4,-20}", app.Id,app.Name,app.Location,app.Qualification,app.Experience);
                }
            }
        }
    }
}
