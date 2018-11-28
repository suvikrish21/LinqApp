using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp1.EmpService;

namespace WebApp1.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {

            EmpService.EmpServiceClient svc = new EmpService.EmpServiceClient();
            var empList = svc.RetreiveEmployees().ToList();

            return View(empList);
        }



        public ActionResult Create(EmployeeType emp)
        {

            if (emp.Id.ToString() == "0")
                return View(emp);

            EmpService.EmpServiceClient svc = new EmpService.EmpServiceClient();
            var status = svc.AddEmployee(emp);

            TempData["EmpStatus"] = status;

            return RedirectToAction("Index");
        }




        [HttpGet]
        public ActionResult Edit(int id)
        {

            EmpService.EmpServiceClient svc = new EmpService.EmpServiceClient();
            var empList = svc.RetreiveEmployeeByID(id);

            return View(empList);
        }


        public ActionResult Details(int id)
        {

            EmpService.EmpServiceClient svc = new EmpService.EmpServiceClient();
            var empList = svc.RetreiveEmployeeByID(id);

            return View(empList);
        }

        public ActionResult Delete(int id)
        {

            EmpService.EmpServiceClient svc = new EmpService.EmpServiceClient();
            var status = svc.DeleteEmployee(id);

            TempData["EmpStatus"] = status;

            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult Edit(EmployeeType emp)
        {

           

            EmpService.EmpServiceClient svc = new EmpService.EmpServiceClient();
            var status = svc.UpdateEmployee(emp, emp.Id);

            TempData["EmpStatus"] = status;

            return RedirectToAction("Index");
        }
    }
}