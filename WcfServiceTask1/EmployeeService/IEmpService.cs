using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmpService
    {
        [OperationContract]
        string AddEmployee(EmployeeType value);

        [OperationContract]
        List<EmployeeType> RetreiveEmployees();

        // TODO: Add your service operations here


        [OperationContract]
        EmployeeType RetreiveEmployeeByID(int id);


        [OperationContract]
        string UpdateEmployee(EmployeeType value, int id);

        [OperationContract]
        string DeleteEmployee(int id);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "EmployeeService.ContractType".
    [DataContract]
    public class EmployeeType
    {
         int idValue  ;
        string fnameValue = string.Empty;
        string lnameValue = string.Empty;
        string deptValue = string.Empty;


        [DataMember]
        public int Id
        {
            get { return idValue; }
            set { idValue = value; }
        }

        [DataMember]
        public string FirstName
        {
            get { return fnameValue; }
            set { fnameValue = value; }
        }

        [DataMember]
        public string LastName
        {
            get { return lnameValue; }
            set { lnameValue = value; }
        }

        [DataMember]
        public string DeptNo
        {
            get { return deptValue; }
            set { deptValue = value; }
        }

       
    }
}
