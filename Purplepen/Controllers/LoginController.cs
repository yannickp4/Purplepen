using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Purplepen.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

       /* public ActionResult Login()
        {
            return View();
        }*/

         public ActionResult Login(FormCollection f)
        {
            // opgepast!! elke keer ene gebruiker inlogd wordt hij opgeslagen in db
            Session["accessToken"] = f["accessToken"];
/*
            var accessToken = Session["AccessToken"].ToString();
            var client = new FacebookClient(accessToken);
            dynamic result = client.Get("me", new { fields = "name,id" });

            VideoModel video = new VideoModel();
            User u = new User();
            u.name = result.name;
            u.facebookId = result.id;

            Session["userId"] = video.insertUser(u);
            Session["name"] = u.name;
             */
            ViewBag.status = "loggedIn";
            return RedirectToAction("Index", "Home");
          //  return View();
            
        }

    }
}
