using HiringManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagementSystem.Utils
{
    internal class Printer
    {
        void Print(Job[] jobs)
        {
            for (int i = 0; i < jobs.Length; i++)
            {
                Console.WriteLine($"Title: {jobs[i].Title}");
                Console.WriteLine($"Description: {jobs[i].ExperienceLevel}");
                Console.WriteLine($"salary: {jobs[i].SalaryRange}");
                Console.WriteLine($"Location: {jobs[i].Location}");
            }
        }
        void Print(User[] registrations)
        {
            for (int i = 0; i < registrations.Length; i++)
            {
                Console.WriteLine($"Name:{registrations[i].FirstName}");
                Console.WriteLine($"Email{registrations[i].Email}");
            }
        }
    }
}
