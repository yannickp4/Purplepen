using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Purplepen.Models
{
    public class Admin : Controller
    {
        //
        // GET: /Admin/
        dcPurplepenDataContext dc = new dcPurplepenDataContext();

        public class UserA
        {
            public string Name { get; set; }
            public Int64 ID { get; set; }
        }

        public void kickThisUser(int ID)
        {
            var kick = (from k in dc.users where k.fb_id == ID select k).First();
            kick.permission = 3;
            dc.SubmitChanges();
        }

        public void Neutralize(int ID)
        {
            var kick = (from k in dc.users where k.fb_id == ID select k).First();
            kick.permission = 0;
            dc.SubmitChanges();
        }

        public void promote(int ID)
        {
            var kick = (from k in dc.users where k.fb_id == ID select k).First();
            kick.permission = 2;
            dc.SubmitChanges();
        }

        public List<UserA> getAllUsers()
        {
            var allUsers = (from p in dc.users where p.permission == 0 select new UserA { Name = p.name, ID = p.fb_id });
            return allUsers.ToList();
        }

        public List<UserA> getKickedUsers()
        {
            var allUsers = (from p in dc.users where p.permission == 3 select new UserA { Name = p.name, ID = p.fb_id });
            return allUsers.ToList();
        }

        public List<UserA> getAdmin()
        {
            var allUsers = (from p in dc.users where p.permission == 2 select new UserA { Name = p.name, ID = p.fb_id });
            return allUsers.ToList();
        }
    }
}
