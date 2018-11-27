using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            TempSvc.TempCFServiceClient svc = new TempSvc.TempCFServiceClient();

            bool processrequest = true;

            do
            {

                Console.WriteLine(" C TO F .. Enter temp in  Celcius ");
                double temperature = Convert.ToDouble(Console.ReadLine());

                double result = svc.CelciusToFarenheit(temperature);

                Console.WriteLine(temperature + " --> " + result);


                Console.WriteLine(" F TO C .. Enter temp in  Farenheit ");
                temperature = Convert.ToDouble(Console.ReadLine());

                double result2 = svc.FarenheitToCelcius(temperature);


                Console.WriteLine(temperature + " --> " + result2);


                Console.WriteLine(" Please N to close this application  or enter to continue");

                string userinput = Console.ReadLine();



                if (userinput.ToUpper() == "N")
                    processrequest = false;

            } while (processrequest);












        }
    }
}
