using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JobServiceTask
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
    {
        private List<JobTypes> AllJobs = new List<JobTypes>();
        public Service2()
        {
            AllJobs.Add(new JobTypes { Id = 11, Name = "Aviation", Role = "Pilot" });
            AllJobs.Add(new JobTypes { Id = 12, Name = "Aviation", Role = "Mechanic" });
            AllJobs.Add(new JobTypes { Id = 13, Name = "Aviation", Role = "Engineer" });

            AllJobs.Add(new JobTypes { Id = 23, Name = "Media", Role = "Editor" });
            AllJobs.Add(new JobTypes { Id = 24, Name = "Media", Role =  "Writer" });
            AllJobs.Add(new JobTypes { Id = 25, Name = "Media", Role = "Developer" });

            AllJobs.Add(new JobTypes { Id = 36, Name = "Medical", Role = "Doctor" });
            AllJobs.Add(new JobTypes { Id = 37, Name = "Medical", Role = "Paramedic" });

            AllJobs.Add(new JobTypes { Id = 41, Name = "Technology", Role = "Developer" });
            AllJobs.Add(new JobTypes { Id = 42, Name = "Technology", Role = "Manager" });
            AllJobs.Add(new JobTypes { Id = 43, Name = "Technology", Role = "Engineer" });

        }


        public List<JobTypes> OpeningJobs()
        {

            

            return AllJobs;



            
        }

        public List<JobTypes> OpeningJobsByRole(string name)
        {
            return AllJobs.Where(jl => jl.Role.Contains(name)).ToList();

        }
    }
}
