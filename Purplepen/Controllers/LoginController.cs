using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Purplepen.Models;
using Facebook;

namespace Purplepen.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Login()
        {
            return View();
        }

        // dcPurplepenDataContext dc = new dcPurplepenDataContext();
        [HttpPost]
        public ActionResult Login(FormCollection f)
        {
            Session["accessToken"] = f["accessToken"];
            //string accessToken = f["accessToken"].ToString();
            var accessToken = Session["accessToken"].ToString();
            var client = new FacebookClient(accessToken);
            dynamic result = client.Get("me", new { fields = "name,id" });

            User chkUser = new User();
            int records = (chkUser.checkIfUserExcists(Convert.ToInt32(result.id)));
            var countRecords = records;

            if (countRecords >= 1)
            {
                //This user is already registered
                User usr = new Models.User();
                int per = usr.checkPermission(Convert.ToInt32(result.id));
                if (per == 3)
                {
                    ViewBag.blacklist = "Blocked";
                    return View();
                }
            }
            else
            {
                user u = new user();
                u.fb_id = Convert.ToInt32(result.id);
                u.name = result.name;
                u.permission = 0;
                u.rank_id = 0;
                u.comments_min = 0;
                u.comments_plus = 0;
                u.report = 0;

                User newUser = new User();
                newUser.addUser(u);
            }

            Session["fbID"] = result.id;

            //  ViewBag.status = "loggedIn";
            return RedirectToAction("Index", "Home");
            // return View();

        }
    }
}
