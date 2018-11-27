using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibTask1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost svcHost = null;

            try
            { 
            svcHost = new ServiceHost(typeof(WcfServiceLibTask1.Service1));
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
