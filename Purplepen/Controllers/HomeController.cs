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
            c.upload_id = Convert.ToInt32( form["designID"]); //aanpassen
            c.user_id = Convert.ToInt32( Session["fbID"].ToString()); //aanpassen
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

        
        public ActionResult Flag(int ID)
        {
            Current c = new Current();
            ViewBag.flag = c.flagThis(ID);
            ViewBag.current = c.getCurrentDesign();
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
             Current cur = new Current();
             ViewBag.current = cur.getCurrentDesign();

            Comment comm = new Comment();
            int ID = cur.getCurrentID();
            ViewBag.allcomments = comm.allComments(ID);
            ViewBag.alldots = comm.allDots(ID);
            return View();

        }


    }
}
