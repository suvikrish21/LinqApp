using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JobServiceTask
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService2
    {

        [OperationContract]
        List<JobTypes> OpeningJobs();

        [OperationContract]
        List<JobTypes> OpeningJobsByRole(string name);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class JobTypes
    {
        int idValue;
        string  nameValue = string.Empty;
        string roleValue = string.Empty;


        [DataMember]
        public string Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

        [DataMember]
        public int Id
        {
            get { return idValue; }
            set { idValue = value; }
        }

        [DataMember]
        public string Role
        {
            get { return roleValue; }
            set { roleValue = value; }
        }
    }
}
