using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHomepage.Controllers
{
    public class IllustController : AbstractController
    {
        // GET: Illust
        public ActionResult Index()
        {
            return View();
        }
    }
}