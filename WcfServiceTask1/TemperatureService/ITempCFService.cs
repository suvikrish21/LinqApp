using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureService
{
    [ServiceContract]
    public interface ITempCFService
    {
        [OperationContract]
        double CelciusToFarenheit(double value);

        [OperationContract]
        double FarenheitToCelcius(double value);

        // TODO: Add your service operations here


       
    }

}
