using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Purplepen.Models;

namespace Purplepen.Controllers
{
    public class BeamerController : Controller
    {
        //
        // GET: /Beamer/

        public ActionResult Beamer()
        {
            Current cur = new Current();
            ViewBag.current = cur.getCurrentDesign();

            Comment comm = new Comment();
            int ID = cur.getCurrentID();
            ViewBag.allcomments = comm.lastTenComments(ID);
        
            return View();
        }

    }
}
