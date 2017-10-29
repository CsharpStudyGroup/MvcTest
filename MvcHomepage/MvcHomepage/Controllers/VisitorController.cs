using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHomepage.Controllers
{
    public class VisitorController : AbstractController
    {
        // GET: Visitor
        public ActionResult Index()
        {
            return View();
        }
    }
}