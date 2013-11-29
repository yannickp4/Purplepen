using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Purplepen.Models
{
    public class Upload
    {
        dcPurplepenDataContext dc = new dcPurplepenDataContext();

        public void uploadimage(uploadversion image,project project) {
            if (project.project_id == 0)
            {
                dc.projects.InsertOnSubmit(project);
                dc.SubmitChanges();
                var projectid = (from p in dc.projects where p.user_id == project.user_id && p.name == project.name select p.project_id).Single();
                image.project_id = Convert.ToInt32(projectid);
            }
            
            dc.uploadversions.InsertOnSubmit(image);
            dc.SubmitChanges();
        }

        public List<project> allProjects(int user_id) {
            var result = (from p in dc.projects where p.user_id == user_id select p).ToList();
            return result;
        }

    }
}