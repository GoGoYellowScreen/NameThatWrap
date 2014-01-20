using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NameThatWrap.Models;
using NameThatWrap.data;

namespace NameThatWrap.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Level (int WrapID)
        {
            NameThatWrapEntities context = new NameThatWrapEntities();

            //var maxWrapID = context.Wraps.OrderByDescending(w => w.WrapID).First(); why is this null?
            //var maxWrapID = context.Wraps.Max(w => w.WrapID); why is this 0?

            Random rand = new Random();
            var nextLevelID = rand.Next(1, 51);

            var rightWrap = context.Wraps.Where(w => w.WrapID == WrapID).First();
            ViewBag.rightWrap = rightWrap;

            var randID = rand.Next(1, 51);

            if (randID == WrapID)
            {
                while (randID == WrapID)
                {
                    var backupID = rand.Next(1, 51);
                    randID = backupID;
                }
            }

            var wrongWrap = context.Wraps.Where(w => w.WrapID == randID).First();
            ViewBag.wrongWrap = wrongWrap;

            if (nextLevelID == randID)
            {
                while (nextLevelID == randID)
                {
                    var extraID = rand.Next(1, 51);
                    nextLevelID = extraID;
                }
            }

            ViewBag.NextLevelWrapID = nextLevelID;
            var nextLevelWrap = context.Wraps.Where(w => w.WrapID == nextLevelID).First();
            ViewBag.nextLevelWrap = nextLevelWrap;

            var numCorrect = 0;
            ViewBag.numCorrect = numCorrect;
            var numAttempted = 1;
            ViewBag.numAttempted = numAttempted;

            var coin = rand.Next(1, 3);
            if (coin == 1)
            {
                ViewBag.TopWrap = rightWrap;
                ViewBag.BottomWrap = wrongWrap;
                ViewBag.topchoice = "rightchoice";
                ViewBag.bottomchoice = "wrongchoice";
            }
            else
            {
                ViewBag.TopWrap = wrongWrap;
                ViewBag.BottomWrap = rightWrap;
                ViewBag.topchoice = "wrongchoice";
                ViewBag.bottomchoice = "rightchoice";
            }
            ViewBag.coin = coin;

            return View(rightWrap);
        }

        public ActionResult YouLose()
        {
            Random rand = new Random();
            ViewBag.WrapID = rand.Next(1, 51);
            return View();
        }

        public ActionResult Details(int WrapID)
        {
            NameThatWrapEntities context = new NameThatWrapEntities();
           var model = context.Wraps.Where(w => w.WrapID == WrapID).First();
            return View(model);
        }

        public ActionResult WrapList()
        {
            WrapListModel model = new WrapListModel();
            NameThatWrapEntities context = new NameThatWrapEntities();
            model.WrapList = context.Wraps.ToList();
            return View(model);
        } 
    }
}
