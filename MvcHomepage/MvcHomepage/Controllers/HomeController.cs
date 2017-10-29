using MaruhanItem.Muser;
using MvcHomepage.App_Start;
using System.Web.Mvc;

namespace MvcHomepage.Controllers
{
    public class HomeController : AbstractController
    {
        public ActionResult Index()
        {
            var user = new Muser()
            {
                Name = "test"
            };
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}