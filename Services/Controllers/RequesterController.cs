using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Services.Controllers
{
    public class RequesterController : Controller
    {
        // GET: Requester
        public ActionResult Index()
        {
            var requester = new List<Requester>()
            {
                new Requester{Id=1,Name="Owais"},
                new Requester{Id=2,Name="Ahmad"}
            };

            return View(requester);
        }
    }
}