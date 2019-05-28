using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersAwardsBLL;

namespace UsersAwardsPLWEB.Controllers
{
    public class AwardController : Controller
    {
        public static AwardsBL listOfAwards = new AwardsBL();

        static AwardController()
        {
            listOfAwards.GetList();
        }

        public ActionResult Index()
        {
            ViewBag.HeaderText = "Awards list";
            
            return View(listOfAwards.GetList());
        }

        public ActionResult Details (int id)
        {
            Award aw = listOfAwards.GetList().First(a => a.AwardId == id);
            return View(id);
        }
    }
}