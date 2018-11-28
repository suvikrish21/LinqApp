using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public string Hello()
        {
            TaskService1.Service1Client svc = new TaskService1.Service1Client("BasicHttpBinding_IService1");


            return (svc.SayHello(string.Empty));
        }

        public string Program()
        {

            TaskService2.Service1Client svc = new TaskService2.Service1Client("NetTcpBinding_IService11");
            return (svc.TodayProgram(string.Empty));
        }



        public ActionResult Index()
        {
            return View();
        }
    }
}