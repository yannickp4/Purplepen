using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Purplepen.Models
{
    public class Upload
    {
        dcPurplepenDataContext dc = new dcPurplepenDataContext();

        public class ownproject
        {
            public String latestVersion { get; set; }
            public String title { get; set; }
            public int projectId { get; set; }
            public DateTime datum { get; set; }
        }

        public void uploadimage(uploadversion image, project project)
        {
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

        public List<project> allProjects(int user_id)
        {
            var result = (from p in dc.projects where p.user_id == user_id select p).ToList();
            return result;
        }

        public List<ownproject> allOwnProjects(int user_id)
        {
            List<ownproject> realresult = new List<ownproject>();
            int blap = 0;
            var result = (from p in dc.projects join i in dc.uploadversions on p.project_id equals i.project_id select new ownproject { title = p.name, projectId = p.project_id, latestVersion = i.path, datum = i.datum }).ToList();
            for (int x = 0; x < result.Count(); x++)
            {
                realresult.Add(result[x]);
                for (int y = 0; y < result.Count(); y++)
                {
                    if (realresult[blap].projectId == result[y].projectId && realresult[blap].datum < result[y].datum)
                    {
                        realresult.Remove(realresult.Last());
                        blap--;
                    }
                }
                blap++;
            }
            return realresult;
        }

    }
}