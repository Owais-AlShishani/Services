using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Models;
using Services.ViewModels;

namespace Services.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            var services = GetServices();
            return View(services);

        }
        public ActionResult Details(int id)
        {
            var services = GetServices().SingleOrDefault(c => c.ServiceId == id);

            if (services == null)
            {
                return HttpNotFound();
            }
            return View(services);
        }
        private IEnumerable<Service> GetServices()
        {
            var service = new List<Service>()
            {
              new Service{  ServiceId = 1,
                ServiceName = "Passport",
                ServiceDuration = 3,
                ServiceCost = 12,
                Active = true },

               new Service{ ServiceId = 2,
                ServiceName = "Birth",
                ServiceDuration = 3,
                ServiceCost = 12,
                Active = true}
            };
            return service;
        }

        //var requester = new List<Requester>()
        //{
        //    new Requester{Id=1,Name="Owais"},
        //    new Requester{Id=2,Name="Ahmad"}
        //};


        //var ser = new ServicesViewModels()
        //{
        //    Service = service,
        //    Requester = requester
        //};



        //return View(ser);
        //return View(service);
        // return new ViewResult();
        //return new HttpNotFoundResult();
        //return RedirectToAction("index");
    }
}