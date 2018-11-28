using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.Models
{
    public class Calculations
    {
        // GET: Calc
        public int Number1 { get; set; }

        public int Number2 { get; set; }

        public double Result { get;set; }


        public string Operation { get; set; }
    }
}