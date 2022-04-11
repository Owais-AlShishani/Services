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

            var requester = GetRequesters();

            return View(requester);

        }
        public ActionResult Details(int id)
        {
            var req = GetRequesters().SingleOrDefault(c => c.Id == id);

            if (req == null)
            {
                return HttpNotFound();
            }
            return View(req);
        }
        private IEnumerable<Requester> GetRequesters()
        {
            return new List<Requester>
            {
                new Requester { Id = 1, Name = "John Smith" },
                new Requester { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}