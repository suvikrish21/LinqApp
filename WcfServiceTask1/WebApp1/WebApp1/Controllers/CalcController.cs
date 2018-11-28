using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
       

        public ActionResult Index(Calculations calc)
        {

            if (!string.IsNullOrEmpty(calc.Operation))
            {
                CalcService.CalculatorServiceClient svc = new CalcService.CalculatorServiceClient();

                double result = 0;

                switch(calc.Operation)
                {
                    case "+":
                        result = svc.Add(calc.Number1, calc.Number2);
                        break;

                    case "-":
                        result = svc.Subtract(calc.Number1, calc.Number2);
                        break;

                    case "/":
                        result = svc.Divide(calc.Number1, calc.Number2);
                        break;


                    case "*":
                        result = svc.Multiply(calc.Number1, calc.Number2);
                        break;


                }
                calc.Result = result;
            }

            return View(calc);
        }
    }
}