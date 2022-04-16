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

        private ServicesContext _context;

        public RequesterController()
        {
            _context = new ServicesContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        // GET: Requester
        public ActionResult Index()
        {

            var requester = _context.Requesters.ToList();

            return View(requester);

        }
        public ActionResult Details(int id)
        {
            var req = _context.Requesters.SingleOrDefault(c => c.Id == id);

            if (req == null)
            {
                return HttpNotFound();
            }
            return View(req);
        }
    }
}