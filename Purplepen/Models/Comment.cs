using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Purplepen.Models
{
    public class Comment : Controller
    {
        //
        // GET: /Comment/

        public ActionResult Index()
        {
            return View();
        }

    }
}
