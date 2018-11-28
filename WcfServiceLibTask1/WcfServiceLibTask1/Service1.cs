using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibTask1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string SayHello(string name)
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime.Hour < 12)
                return "Good Morning ";
            else if (currentTime.Hour < 17)
                return "Good Afternoon";
            else
                return "Good Evening";





        }

        public string TodayProgram(string name)
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime.DayOfWeek == DayOfWeek.Saturday || currentTime.DayOfWeek == DayOfWeek.Sunday)
                return "Happy Weekend ";

            else
                return "Enjoy Working Day";

        }
    }
}
