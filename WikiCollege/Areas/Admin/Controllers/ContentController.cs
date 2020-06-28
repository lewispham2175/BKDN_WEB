using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiCollege.Models.EF;

namespace WikiCollege.Areas.Admin.Controllers
{
    public class ContentController : Controller
    {
        // GET: Admin/Content
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        WikiCollegeDBContext db = new WikiCollegeDBContext();
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Create(CONTENT ct)
        {
            if (ModelState.IsValid)
            {
                CONTENT obj = new CONTENT();
                obj.author_ID = 1;
                obj.meta_title = ct.meta_title;
                obj.title = ct.title;
                obj.desciption = ct.desciption;
                obj.detail = ct.detail;
                obj.created_date = DateTime.Today;
                obj.status = ct.status;
                obj.top_hot = DateTime.Today.AddDays(2);
                obj.view_count = ct.view_count;
                obj.tags = ct.tags;
                db.CONTENT.Add(obj);
                db.SaveChanges();
            }
            return View();
        }

        public ActionResult Display()
        {
            var query = from CONTENT in db.CONTENT select CONTENT;
            var res = query.ToList();
            return View(res);
        }
    }
}