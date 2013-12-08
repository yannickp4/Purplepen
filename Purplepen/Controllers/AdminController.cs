using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Purplepen.Models;

namespace Purplepen.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Admin()
        {
            User usr = new Models.User();
            int per = usr.checkPermission(Convert.ToInt32(Session["fbID"].ToString()));
            if (per != 2)
            {
                ViewBag.allow = "noADMIN";
                return View();
            }

            Admin a = new Admin();
            ViewBag.allusers = a.getAllUsers();
            ViewBag.kicked = a.getKickedUsers();
            ViewBag.admin = a.getAdmin();
            return View();
        }

        
        public ActionResult Kick(FormCollection form)
        {
            int ID = Convert.ToInt32(form["Users"]);
            Admin a = new Admin();
            a.kickThisUser(ID);
            ViewBag.allusers = a.getAllUsers();
            ViewBag.kicked = a.getKickedUsers();
            ViewBag.admin = a.getAdmin();
            return RedirectToAction("Admin");
        }

        public ActionResult UnKick(FormCollection form)
        {
            int ID = Convert.ToInt32(form["Users"]);
            Admin a = new Admin();
            a.Neutralize(ID);
            ViewBag.allusers = a.getAllUsers();
            ViewBag.kicked = a.getKickedUsers();
            ViewBag.admin = a.getAdmin();
            return RedirectToAction("Admin");
        }

        public ActionResult Promote(FormCollection form)
        {
            int ID = Convert.ToInt32(form["Users"]);
            Admin a = new Admin();
            a.promote(ID);
            ViewBag.allusers = a.getAllUsers();
            ViewBag.kicked = a.getKickedUsers();
            ViewBag.admin = a.getAdmin();
            return RedirectToAction("Admin");
        }

        public ActionResult Demote(FormCollection form)
        {
            int ID = Convert.ToInt32(form["Users"]);
            Admin a = new Admin();
            a.Neutralize(ID);
            ViewBag.allusers = a.getAllUsers();
            ViewBag.kicked = a.getKickedUsers();
            ViewBag.admin = a.getAdmin();
            return RedirectToAction("Admin");
        }
    }
}