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
            ViewBag.projects = projects.allOwnProjects(65465416);
            return View();
        }

    }
}
