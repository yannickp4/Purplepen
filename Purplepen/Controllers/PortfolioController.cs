using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Purplepen.Models;

namespace Purplepen.Controllers
{
    public class PortfolioController : Controller
    {
        //
        // GET: /Portfolio/

        public ActionResult Portfolio()
        {
            Upload projects = new Upload();
            Int64 session_id = Convert.ToInt64(Session["fbID"]);
            ViewBag.projects = projects.allOwnProjects(session_id);
            return View();
        }
        public ActionResult deleteProject(int projectid) {
            Upload projects = new Upload();
            projects.deleteProject(projectid);
            return RedirectToAction("Portfolio");
        }

    }
}
