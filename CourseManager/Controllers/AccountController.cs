using CourseManager.Models;
using CourseManager.Models.ValidatebleObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CourseManager.Controllers
{
    public class AccountController : Controller
    {
        private CourseManagerContext db = new CourseManagerContext();

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginInput input)
        {
            if (ModelState.IsValid)
            {
                var users = db.Users.FirstOrDefault(u => u.Account == input.Account && u.Password == input.Password);
                if (users == null)
                {
                    ModelState.AddModelError("password", "用户名不存在或密码错误");
                    return View(input);
                }
                HttpContext.Session?.Add("users", users.Account);
                var cookie = new HttpCookie("users", users.Account.EncryptQueryString())
                {
                    Expires = DateTime.Now.AddHours(3)
                };
                Response.Cookies.Add(cookie);

                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}