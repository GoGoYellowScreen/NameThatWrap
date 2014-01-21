using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NameThatWrap.Models;
using NameThatWrap.data;
using System.Data.Entity.Validation;

namespace NameThatWrap.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            Random rand = new Random();
            ViewBag.WrapID = rand.Next(1, 51);
            return View();
        }


        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(SignInModel model)
         {
            if (!ModelState.IsValid)
                return View(model);
            else
            {
                NameThatWrapEntities context = new NameThatWrapEntities();
                string hashedPassword = model.Password.GetHashCode().ToString();
                User user = context.Users.Where(u => u.Email == model.Email && u.Password == hashedPassword).SingleOrDefault();
                if (user == null)
                    return View(model);
                Session["logged_in"] = "true";
                Session["name"] = user.FirstName;
                Random rand = new Random();
                model.WrapID = rand.Next(1, 51);
                return View("WelcomeBack", model);
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User model)
        {
            Random rand = new Random();
            ViewBag.WrapID = rand.Next(1, 51);
            if (ModelState.IsValid)
            {
                model.Password = model.Password.GetHashCode().ToString();
                NameThatWrapEntities context = new NameThatWrapEntities();
                context.Users.Add(model);
                context.SaveChanges();
                return View("ThanksReg", model);
            }
            else
            {
                return View(model);
            }
        }

    }
}