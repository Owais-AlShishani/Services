using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Models;

namespace Services.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            var service = new Service()
            {
                ServiceId = 1,
                ServiceName = "Passport",
                ServiceDuration = 3,
                ServiceCost = 12,
                Active = true
            };

            //return View(service);
            // return new ViewResult();
            //return new HttpNotFoundResult();
            return RedirectToAction("index");
        }
    }
}