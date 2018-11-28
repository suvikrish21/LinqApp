using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //EmployeeService.EmpService empSvc = new EmployeeService.EmpService();

            //EmployeeService.EmployeeType empl = new EmployeeService.EmployeeType();
            //empl.DeptNo = "D2";
            //empl.FirstName = "test";
            //empl.LastName = "test";
            //empl.Id = 1000;
            //empSvc.AddEmployee(empl);

            ServiceHost svcHost = null;

            try
            {
                svcHost = new ServiceHost(typeof(EmployeeService.EmpService));
                svcHost.Open();

                Console.WriteLine("Service is running at " + DateTime.Now);



            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong" + ex.StackTrace);
                Console.WriteLine(ex.Message);
                svcHost = null;
            }

            Console.WriteLine(" Please any key to shut down the service");
            Console.ReadKey();

            if (svcHost != null)
            {
                Console.WriteLine(" Please any key to shut down the service");
                Console.ReadKey();


                svcHost.Close();
                svcHost = null;

            }










        }
    }
}
