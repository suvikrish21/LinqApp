using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class JobController : Controller
    {
        public ActionResult List()
        {

            JobService.Service2Client svc = new JobService.Service2Client();
            return View(svc.OpeningJobs());



        }

        public ActionResult Index(string role, string btn)
        {

            JobService.Service2Client svc = new JobService.Service2Client();




            if (btn == "All" || string.IsNullOrEmpty(btn))
                return View(svc.OpeningJobs());
            else
                return View(svc.OpeningJobsByRole(role));



        }


    }
}

