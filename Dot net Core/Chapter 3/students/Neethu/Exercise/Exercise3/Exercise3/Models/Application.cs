using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Models
{
    public class Application
    {
        public int Id { get; set; } 
        public string Experience { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }

        public Application() { }
        public Application(int jobid, string name,string location,string experience,string qualification)
        {
            Id = jobid;
            Experience = experience;
            Name = name;
            Location = location;
            Qualification = qualification;

        }
    }
}
