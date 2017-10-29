using MvcHomepage.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHomepage.Controllers
{
    public class AbstractController : Controller
    {
        private MaruhanDbContext _context;

        public MaruhanDbContext DB()
        {
            if (_context == null) _context = new MaruhanDbContext();
            return _context;
        }
    }
}