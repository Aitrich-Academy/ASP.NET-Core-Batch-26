using Admin_job.Interface;
using Admin_job.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_job.Manager
{
    internal class JobManager:IJobProvider
    {
        private List<Job> jobs = new List<Job>();
        public void PostJob(Job job)
        {
            job.Id = jobs.Count;
            jobs.Add(job);
        }

        public List<Job> GetJobs()
        {
            return jobs;
        }

    }
}
