using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Purplepen.Models
{

    public class User : Controller
    {
        dcPurplepenDataContext dc = new dcPurplepenDataContext();
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        public void addUser(user u)
        {
            dc.users.InsertOnSubmit(u);
            dc.SubmitChanges();
        }

        public int checkIfUserExcists(int id)
        {
            int count = (from a in dc.users where a.fb_id == id select a).Count();
            //int countB = Convert.ToInt32(count);
            return count;
        }

        public int checkPermission(int id)
        {
            int permision = 666;
            var check = (from p in dc.users where p.fb_id == id select p).First();
            permision = check.permission;
            return permision;
        }
    }
}
