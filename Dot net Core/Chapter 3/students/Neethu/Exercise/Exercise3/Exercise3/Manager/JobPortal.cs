using Exercise3.Interface;
using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Manager
{
    public class JobPortal:IJobProvider
    {
        private List<Job> jobs=new List<Job>();
        public JobPortal() { }
        public void PostJob(Job job)
        {
            job.Id=jobs.Count;
            jobs.Add(job);
        }
        public List<Job> GetJobs()
        {
            return jobs;
        }
    }
}
