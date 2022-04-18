using Services.Models;
using System.Data.Entity;
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

            var requester = _context.Requesters.Include(c => c.MemberShipType).ToList();

            return View(requester);

        }
        public ActionResult Details(int id)
        {
            var req = _context.Requesters.Include(c=>c.MemberShipType).SingleOrDefault(c => c.Id == id);

            if (req == null)
            {
                return HttpNotFound();
            }
            return View(req);
        }
    }
}