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

    }
}
