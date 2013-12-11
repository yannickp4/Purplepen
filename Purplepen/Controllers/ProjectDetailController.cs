using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Purplepen.Models;

namespace Purplepen.Controllers
{
    public class ProjectDetailController : Controller
    {
        //
        // GET: /ProjectDetail/
        
        public ActionResult ProjectDetail()
        {
            int projectid = Convert.ToInt32(Request.QueryString["projectid"]);
            Upload u = new Upload();
            ViewBag.projectdetail = u.projectDetail(projectid);
            List<Upload.projectdetail> projectnaam = u.projectDetail(projectid);
                ViewBag.projectname=projectnaam[0].projectname;
            return View();
        }

        public ActionResult VersionDetail() {
            int versionid = Convert.ToInt32(Request.QueryString["versionid"]);
            Comment commentske = new Comment();
            Upload u = new Upload();
            ViewBag.allcomments=commentske.allComments(versionid);
            ViewBag.allcommentsGeneral=commentske.allCommentsGeneral(versionid);
            ViewBag.alldots=commentske.allDots(versionid);
            ViewBag.current = u.versiondetail(versionid);
            Current c = new Current();
            ViewBag.flag = c.flagThis(versionid);
            return View();
        }

        public ActionResult CommentView()
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

        public ActionResult CommentView1()
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

        public ActionResult CommentView2()
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

        public ActionResult CommentView3()
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

        public ActionResult Dots()
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

    }
}
