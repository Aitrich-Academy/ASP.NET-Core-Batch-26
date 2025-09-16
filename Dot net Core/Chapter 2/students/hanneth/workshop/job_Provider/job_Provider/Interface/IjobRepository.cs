using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job_Provider.Interface
{
    internal interface IjobRepository
    {
        void AddJob();
        void ListJob();
        public void Login();
        public void Register();
    }
}
