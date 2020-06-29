using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiCollege.Areas.Admin.Models;
using WikiCollege.Common;
using WikiCollege.Models.Dao;

namespace WikiCollege.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new AccountDao();
                string res = dao.Login(model.UserName, Encryptor.MD5Hash(model.PassWord));
                if (res == "ok")
                {
                    var acc = dao.getByUserName(model.UserName);
                    var accSession = new AccountLogin();
                    accSession.UserName = acc.user_name;
                    accSession.accID = acc.acc_ID;
                    Session.Add(CommonConst.USER_SESSION, accSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                if (res == "wrong-pass")
                {
                    ModelState.AddModelError("", "Mật khẩu sai!");
                }
                else
                if (res == "blocked")
                {
                    ModelState.AddModelError("", "Tài khoản bị khóa!");
                }
                else
                if (res == "not-allowed")
                {
                    ModelState.AddModelError("", "Truy cập bị từ chối!");
                }
                else
                if (res == "user-404")
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại!");
                }
            }
            return View("Index");
        }
    }
}