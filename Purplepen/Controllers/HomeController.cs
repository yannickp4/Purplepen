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


        // [AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult Index(string button)
        //{
        //    Comment comm = new Comment();
        //    comment c = new comment();

        //    if (button == "plus")
        //    {
        //        c.score += 1;
        //    }
        //    comm.placeComment(c);
        //    return View();
        //}


        [HttpPost]
        public ActionResult Index(FormCollection form, string button)
        {
            Comment comm = new Comment();
            comment c = new comment();
            dot d = new dot();

            if (button != "Send")
            {
                string[] pmID = button.Split(',');

                string plusMin = pmID[0];
                int ID = Convert.ToInt32(pmID[1]);
                int score = Convert.ToInt32(pmID[2]);


                if (plusMin == "plus")
                {
                    if (score <= 100)
                    {
                        comm.updateScore(ID);
                    }
                }
                else if (plusMin == "min")
                {
                    comm.updateScoreMin(ID);
                }
            }
            else
            {
                c.description = form["commentText"];
                c.upload_id = Convert.ToInt32(form["designID"]); //aanpassen
                c.user_id = Convert.ToInt64(Session["fbID"].ToString()); //aanpassen
                c.score = 0; //aanpassen
                c.datum = DateTime.Now;
                c.category = 0;
                c.dot_id = comm.getID() + 1;

                d.dot_x = Convert.ToInt32(form["dotX"]);
                d.dot_y = Convert.ToInt32(form["dotY"]);

                if (string.IsNullOrEmpty(form["dotY"]))
                {
                    c.title = "general";
                    c.dot_id = 0;
                    comm.placeComment(c);
                }
                else
                {
                    c.title = "dot";
                    comm.placeComment(c);
                    comm.placeDot(d);
                }
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
            ViewBag.allcommentsGeneral = comm.allCommentsGeneral(ID);
            ViewBag.alldots = comm.allDots(ID);
            return View();

        }

        //public ActionResult Plus()
        //{
        //    int plus = Convert.ToInt32(Request.QueryString["commentId"]);
        //    Comment comm = new Comment();
        //    comment c = new comment();

        //    c.score += 1;


        //    return View();
        //}

        //public ActionResult min()
        //{
        //    Request.QueryString["commentId"];

        //}


    }
}
