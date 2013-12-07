using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Purplepen.Models;

namespace Purplepen.Controllers
{
    public class HistoryController : Controller
    {
        //
        // GET: /History/

        public ActionResult History()
        {
            Upload projects = new Upload();
            ViewBag.projects = projects.allHistory();
            return View();
        }

    }
}
