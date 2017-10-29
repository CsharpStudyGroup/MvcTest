using MaruhanItem.Diary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHomepage.Controllers
{
    public class DiaryController : AbstractController
    {
        // GET: Diary
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Write()
        {
            return View();
        }

        [HttpPost]
        public JsonResult WriteDiary(DiaryItem diary)
        {
            var item = DB().Set<DiaryItem>();
            item.Add(new DiaryItem
            {
                Title = diary.Title,
                Contents = diary.Contents,
                RegDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                UserId = 1,
                IsSecret = diary.IsSecret,
                State = "REG",
                HitCount = 0
            });
            DB().SaveChanges();
            return Json(new { error = false, result = "success" });
        }

        public ActionResult Modify()
        {
            return View();
        }

        public ActionResult Read()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetList()
        {
            return Json(new { },JsonRequestBehavior.AllowGet);
        }
    }
}