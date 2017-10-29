using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHomepage.Controllers
{
    public class WalletController : AbstractController
    {
        // GET: Wallet
        public ActionResult Index()
        {
            return View();
        }
    }
}