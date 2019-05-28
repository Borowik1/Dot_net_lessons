using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersAwardsBLL;
using UsersAwardsPL;

namespace UsersAardsWEB.Controllers
{
    public class UserController : Controller
    {
        public static AwardsBL listOfAwards = new AwardsBL();
        public static UsersBL listOfUsers = new UsersBL();

        // GET: User
        public ActionResult Index()
        {
            return View(listOfUsers.GetList());
        }

        public ActionResult Details(int id)
        {
            var currentUser = new User();
            foreach (User us in listOfUsers.GetList())
            {
                if (id == us.Id)
                {
                    currentUser = us;
                }
            }
            return View(currentUser);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Details(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            var currentUser = new User();
            if (id == 0)
            {
                currentUser.DateOfBirth = DateTime.Now;
                return View(currentUser);
            }
            foreach (User us in listOfUsers.GetList())
            {
                if (id == us.Id)
                {
                    currentUser = us;
                }
            }
            return View(currentUser);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var editedUser = new User(Convert.ToInt32(collection["Id"]),
                                          collection["FirstName"],
                                          collection["LastName"],
                                          Convert.ToDateTime(collection["DateOfBirth"]),
                                          new List<Award>());
                for (int i = 5; i < collection.Count; i++)
                {
                    foreach (Award aw in listOfAwards.GetList())
                    {
                        if (aw.AwardId == Int32.Parse(collection.AllKeys[i]))
                        {
                            editedUser.Awards.Add(aw);
                        }
                    }
                }

                if(editedUser.Id == 0)
                {
                    listOfUsers.Add(editedUser);
                }
                else
                {
                    listOfUsers.Edit(editedUser);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            var currentUser = new User();
            foreach(User us in listOfUsers.GetList())
            {
                if(id == us.Id)
                {
                    currentUser = us;
                }
            }
            return View(currentUser);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                listOfUsers.Remove(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
