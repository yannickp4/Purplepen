using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Purplepen.Models
{
    public class Current : Controller
    {
        dcPurplepenDataContext dc = new dcPurplepenDataContext();

        //
        // GET: /Current/

        public ActionResult Index()
        {
            return View();
        }

        public class currentDesign
        {
            public string url { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public int versionID { get; set; }
        }

        public List<currentDesign> getCurrentDesign()
        {


            //check if er een record is met viewed == 1
            var a = (from d in dc.uploadversions where d.viewed == 1 select d).Take(1);
            if (a.Count() == 0)
            {
                //indien niet: 
                //get next design
                var s = (from d in dc.uploadversions where d.viewed == 0 select d).Count();
                if (s == 0)
                {
                    var curD2 = (from c in dc.uploadversions where c.viewed == 2 orderby c.version_id descending select c).Take(1).First();
                    curD2.viewed = 1;
                    curD2.beamer = DateTime.Now;
                    dc.SubmitChanges();
                }
                else
                {
                    var curD2 = (from c in dc.uploadversions where c.viewed == 0 orderby c.version_id select c).Take(1).First();
                    curD2.viewed = 1;
                    curD2.beamer = DateTime.Now;
                    dc.SubmitChanges();
                }
            }
            else
            {
                //indien zo:
                var curD = (from c in dc.uploadversions where c.viewed == 1 orderby c.version_id  select c).Single();

                //check if (datum on beamer < 5 min) else viewed == 2

                TimeSpan tijd = DateTime.Now.Subtract(curD.beamer);

                if (tijd.Minutes < 1)
                {
                    //  ->>> show dat img
                }
                else
                {
                    var D = (from c in dc.uploadversions where c.viewed == 1 orderby c.version_id select c).Single();
                    D.viewed = 2;
                    dc.SubmitChanges();
                    //  ->>> Zoek nieuw design

                      var s = (from d in dc.uploadversions where d.viewed == 0 select d).Count();
                      if (s == 0)
                      {
                          var curD2 = (from c in dc.uploadversions where c.viewed == 2 orderby c.version_id descending select c).Take(1).First();
                          curD2.viewed = 1;
                          curD2.beamer = DateTime.Now;
                          dc.SubmitChanges();
                      }
                      else
                      {
                          var curD2 = (from c in dc.uploadversions where c.viewed == 0 orderby c.version_id select c).Take(1).First();
                          curD2.viewed = 1;
                          curD2.beamer = DateTime.Now;
                          dc.SubmitChanges();
                      }
                }



            }
      
            //load and return img
            var q8 = (from p in dc.uploadversions
                      join s in dc.projects on p.project_id equals s.project_id
                      where p.viewed == 1
                      select new currentDesign { url = p.path, title = s.name, description = p.description, versionID = p.version_id }).Take(1);
            return q8.ToList();

        }

        public string flagThis(int ID)
        {
            string status = "flag";
            var flagD = (from c in dc.uploadversions where c.version_id == ID select c).First();
            flagD.flag += 1;
            dc.SubmitChanges();

            //kijken of afb al 3 keer geflagged is

            var check = (from f in dc.uploadversions where f.flag == 3 select f);
            if (check.Count() == 0)
            { }
            else
            {
                dc.uploadversions.DeleteOnSubmit(check.First());
                dc.SubmitChanges();
            }


            return status;
        }

        public int getCurrentID()
        {
            int ID;

            try
            {
                //check if er een record is met viewed == 1
                var a = (from d in dc.uploadversions where d.viewed == 1 select d.version_id).Take(1);
                if (a.Count() == 0)
                {
                    //indien niet: 
                    //2's oplijsten en laatse nemen
                    ID = (from c in dc.uploadversions where c.viewed == 2 orderby c.version_id select c.version_id).First();
                }
                else
                {
                    ID = (from d in dc.uploadversions where d.viewed == 1 select d.version_id).First();
                }
            }
            catch (Exception)
            {
                ID = (from c in dc.uploadversions where c.viewed == 2 orderby c.version_id select c.version_id).First();
                throw;
            }

            return ID;
        }
    }
}
