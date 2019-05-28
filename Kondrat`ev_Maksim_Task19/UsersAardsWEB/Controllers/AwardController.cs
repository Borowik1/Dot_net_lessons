using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersAwardsBLL;

namespace UsersAardsWEB.Controllers
{
    public class AwardController : Controller
    {
        public AwardsBL listOfAwards = new AwardsBL();
        // GET: Award
        public ActionResult Index()
        {
            return View(listOfAwards.GetList());
        }

        // GET: Award/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Award/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                listOfAwards.Add(collection["AwardName"], collection["AwardDescription"]);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Award/Edit/5
        public ActionResult Edit(int id)
        {
            Award currentAward = new Award();
            foreach (Award aw in listOfAwards.GetList())
            {
                if (aw.AwardId == id)
                {
                    currentAward = aw;
                }
            }
            return View(currentAward);
        }

        // POST: Award/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                listOfAwards.Edit(new Award(Convert.ToInt32(collection["AwardId"]),
                                            collection["AwardName"],
                                            collection["AwardDescription"]));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Award/Delete/5
        public ActionResult Delete(int id)
        {
            Award currentAward = new Award();
            foreach (Award aw in listOfAwards.GetList())
            {
                if (aw.AwardId == id)
                {
                    currentAward = aw;
                }
            }
            return View(currentAward);
        }

        // POST: Award/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                listOfAwards.Remove(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
