﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalcService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CalculatorService1 : ICalculatorService
    {
        public double Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public double Subtract(int value1, int value2)
        {
            return value1- value2;
        }


        public double Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public double Divide(int value1, int value2)
        {
            return value1 / value2;
        }

       
    }
}
