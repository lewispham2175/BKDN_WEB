﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WikiCollege.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index_Home(int page = 1, int pageSize = 10)
        {
            return View();
        }
    }
}