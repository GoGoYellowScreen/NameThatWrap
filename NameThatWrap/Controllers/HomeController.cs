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

        public ActionResult Details(int wrapID)
        {
            WrapModel myVar =  GetWrap(wrapID);
            return View(myVar);
        }

        public ActionResult WrapList()
        {
            WrapListModel myNewVar = new WrapListModel();

            myNewVar.WrapList = new List<WrapModel>();

            WrapModel myWrap = GetWrap(1);
            myNewVar.WrapList.Add(myWrap);

            WrapModel myWrap2 = GetWrap(2);
            myNewVar.WrapList.Add(myWrap2);

            WrapModel myWrap3 = GetWrap(3);
            myNewVar.WrapList.Add(myWrap3);

            WrapModel myWrap4 = GetWrap(4);
            myNewVar.WrapList.Add(myWrap4);

            WrapModel myWrap5 = GetWrap(5);
            myNewVar.WrapList.Add(myWrap5);

            return View(myNewVar);
    }

        private WrapModel GetWrap (int wrapID)
        {
            NameThatWrapEntities entities = new NameThatWrapEntities();
            
            WrapModel myWrap = new WrapModel();
            switch(wrapID)
            {
                case 1:
                  myWrap.WrapID = 1;
                  myWrap.ImgName = "pfauhanf2012.jpg";
                    myWrap.Colorway = "Black Hemp Pfau";
                        break;
                case 2:
                    myWrap.WrapID = 2;
                    myWrap.ImgName = "hibbiewrap.jpg";
                    myWrap.Colorway = "Rose Silk Hibiscus";
                        break;
                case 3:
                    myWrap.WrapID = 3;
                    myWrap.ImgName = "rainbowwrap.jpg";
                    myWrap.Colorway = "Earthy Rainbow";
                    break;

                case 4:
                    myWrap.WrapID = 4;
                    myWrap.ImgName = "oschamexicachico.jpg";
                        myWrap.Colorway = "Mexica Xica";
                    break;

                case 5:
                    myWrap.WrapID = 5;
                    myWrap.ImgName = "zauberwald.jpg";
                    myWrap.Colorway = "Mystic Forest";
                    break;
            }
            return myWrap;
        }
    }
}
