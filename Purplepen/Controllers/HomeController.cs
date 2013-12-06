using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Purplepen.Models;

namespace Purplepen.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            Comment comm = new Comment();
            comment c = new comment();
            dot d = new dot();

            c.description = form["commentText"];
            c.upload_id = 1; //aanpassen
            c.user_id = 2; //aanpassen
            c.title = "general"; //aanpassen
            c.score = 0; //aanpassen
            c.datum = DateTime.Now;
            c.category = 0;
            c.dot_id = comm.getID() + 1; 
          
            d.dot_x = Convert.ToInt32(form["dotX"]);
            d.dot_y = Convert.ToInt32(form["dotY"]);

            if (string.IsNullOrEmpty(form["dotY"]))
            {
                comm.placeComment(c);
            }
            else
            {
                comm.placeComment(c);
                comm.placeDot(d);
            }

            return RedirectToAction("Index");
        }


        public ActionResult Index()
        {
            Comment comm = new Comment();
            ViewBag.allcomments = comm.allComments();
            ViewBag.alldots = comm.allDots(); 
            return View();

        }


    }
}
