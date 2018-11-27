using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureService
{
    public class TempCFService : ITempCFService
    {

        public double CelciusToFarenheit(double value)
        {
            return (value * (9 / 5) + 32);
        }


        public double FarenheitToCelcius(double value)
        {
            Console.WriteLine("Input" + value);
            return (value - 32) * 5 / 9;
        }



    }


}
