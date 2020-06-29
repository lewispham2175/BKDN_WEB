using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiCollege.Models.Dao;
using WikiCollege.Models.EF;

namespace WikiCollege.Areas.Admin.Controllers
{
    public class ContentController : BaseController
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
            var dao = new ContentDao();
            int inserted = dao.Insert(ct);
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