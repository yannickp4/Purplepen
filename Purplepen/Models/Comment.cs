using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Purplepen.Models
{
    public class Comment
    {

        private dcPurplepenDataContext dc = new dcPurplepenDataContext();

        public void placeComment(comment c)
        {
            dc.comments.InsertOnSubmit(c);
            dc.SubmitChanges();
        }

        public void placeDot(dot d)
        {
            dc.dots.InsertOnSubmit(d);
            dc.SubmitChanges();
        }

        public int getID()
        {
            var id = (from d in dc.dots select d).OrderByDescending(d => d.dot_id).FirstOrDefault();
            var idL = id.dot_id;
            return idL;
        }

        public class commentName
        {
            public String description { get; set; }
            public String naam { get; set; }
        }

        public List<commentName> allComments()
        {
            // var result = (from c in dc.comments select c).ToList();
            var result = (from c in dc.comments
                          join u in dc.users on c.user_id equals u.user_id
                          select new commentName
                          {
                              naam = u.name,
                              description = c.description
                          }).ToList();
            return result;
        }

        public class dotXY
        {
            public int ID { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
            public String description { get; set; }
            public String naam { get; set; }
        }

        public List<dotXY> allDots()
        {
            var result = (from d in dc.dots
                          join c in dc.comments on d.dot_id equals c.dot_id
                          join u in dc.users on c.user_id equals u.user_id
                          select new dotXY
                          {
                              ID = d.dot_id,
                              X = d.dot_x,
                              Y = d.dot_y,
                              description = c.description,
                              naam = u.name
                          }).ToList();
            return result;
        }

        //public List<dot>allDots()
        //{
        //    // var result = (from c in dc.comments select c).ToList();
        //    var result = (from d in dc.dots select last d).ToList();
                          
                         
        //    return result;
        //}






    }
}
