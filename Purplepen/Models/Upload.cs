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
            public int image_id { get; set; }
            public String title { get; set; }
            public int projectId { get; set; }
            public DateTime datum { get; set; }
            public int imgWidth { get; set; }
            public int imgHeight { get; set; }
            public int marginleft { get; set; }
            public int left { get; set; }
            public int top { get; set; }
        }

        public class projectdetail {
            public int project_id{ get; set; }
            public String projectname { get; set; }
            public String description { get; set; }
            public String path { get; set; }
        }

        public void deleteProject(int project_id) {
            project p = (from pr in dc.projects where pr.project_id == project_id select pr).Single();
            dc.projects.DeleteOnSubmit(p);
            dc.SubmitChanges();
        }

        public void uploadimage(uploadversion image, project project)
        {
            //image.datum = image.datum.ToString();
            if (project.project_id == 0)
            {
                dc.projects.InsertOnSubmit(project);
                dc.SubmitChanges();
                var projectid = (from p in dc.projects where p.user_id == project.user_id && p.name == project.name select p.project_id).Single();
                image.project_id = Convert.ToInt32(projectid);
            }
            DateTime blap = DateTime.Parse("1/1/2008 8:30:52");
            image.flag = 0;
            image.beamer = blap;
            image.viewed = 0;
            dc.uploadversions.InsertOnSubmit(image);
            dc.SubmitChanges();
        }

        public List<project> allProjects(Int64 user_id)
        {
            var result = (from p in dc.projects where p.user_id == user_id select p).ToList();
            return result;
        }

        public List<projectdetail> projectDetail(int project_id)
        {
            var result = (from u in dc.uploadversions join p in dc.projects on u.project_id equals p.project_id where u.project_id == project_id orderby u.datum descending select new projectdetail { project_id=p.project_id,projectname=p.name,description=u.description,path=u.path}).ToList();
            return result;
        }

        public List<ownproject> allHistory(){
            List<ownproject> realresult = new List<ownproject>();
            int blap = 0;
            var result = (from p in dc.projects join i in dc.uploadversions on p.project_id equals i.project_id orderby i.version_id descending select new ownproject { title = p.name, projectId = p.project_id, latestVersion = i.path, datum = i.datum, image_id = i.version_id }).ToList();
            for (int x = 0; x < result.Count(); x++)
            {
                realresult.Add(result[x]);
                for (int y = 0; y < result.Count(); y++)
                {
                    if (realresult[blap].projectId == result[y].projectId && realresult[blap].image_id < result[y].image_id)
                    {
                        realresult.Remove(realresult.Last());
                        blap--;
                    }
                }
                blap++;
            }
            int top = 0;
            int left = 0;
            for (int k = 0; k < realresult.Count(); k++)
            {
                System.Drawing.Image objImage = System.Drawing.Image.FromFile(System.Web.HttpContext.Current.Server.MapPath("../uploads/" + realresult[k].latestVersion));
                float width = objImage.Width;
                float height = objImage.Height;
                float w = 0; float h = 0;
                float marginleft = 0;

                if (width > 290)
                {
                    h = height / width * 290;//373
                    w = 290;
                    if (h > 350)
                    {
                        w = width / height * 350;
                        h = 350;
                    }
                }

                else if (height > 350 && width < 290)
                {
                    h = 350;
                    w = width / height * 350;
                }

                if (w < 290) { marginleft = (290 - w) / 2; }

                if (k > 3) { top = realresult[k - 4].imgHeight + realresult[k - 4].top + 5; }
                left += 295;

                double doublek = k;
                double blapke = doublek / 4 - (Math.Floor(doublek / 4));
                if (blapke == 0)
                {
                    left = 0;
                }
                realresult[k].imgWidth = Convert.ToInt32(w);
                realresult[k].imgHeight = Convert.ToInt32(h);
                realresult[k].marginleft = Convert.ToInt32(marginleft);
                realresult[k].left = Convert.ToInt32(left);
                realresult[k].top = Convert.ToInt32(top);


            } return realresult;
        }
        

        public List<ownproject> allOwnProjects(Int64 user_id)
        {
            List<ownproject> realresult = new List<ownproject>();
            int blap = 0;
            var result = (from p in dc.projects join i in dc.uploadversions on p.project_id equals i.project_id where p.user_id == user_id orderby i.version_id descending select new ownproject { title = p.name, projectId = p.project_id, latestVersion = i.path, datum = i.datum, image_id = i.version_id }).ToList();
            for (int x = 0; x < result.Count(); x++)
            {
                realresult.Add(result[x]);
                for (int y = 0; y < result.Count(); y++)
                {
                    if (realresult[blap].projectId == result[y].projectId && realresult[blap].image_id < result[y].image_id)
                    {
                        realresult.Remove(realresult.Last());
                        blap--;
                    }
                }
                blap++;
            }
            int top = 0;
            int left = 0;
            for (int k = 0; k < realresult.Count(); k++ ) {
                System.Drawing.Image objImage = System.Drawing.Image.FromFile(System.Web.HttpContext.Current.Server.MapPath("../uploads/" + realresult[k].latestVersion));
                float width = objImage.Width;
                float height = objImage.Height;
                float w = 0; float h = 0;
                float marginleft = 0;

                if (width > 290)
                {
                    h = height / width * 290;//373
                    w = 290;
                    if (h > 350)
                    {
                        w = width / height * 350;
                        h = 350;
                    }
                }

                else if (height > 350 && width < 290)
                {
                    h = 350;
                    w = width / height * 350;
                }

                if (w < 290) { marginleft = (290 - w) / 2; }

                if (k > 3) { top = realresult[k - 4].imgHeight + realresult[k - 4].top+5; }

                realresult[k].imgWidth = Convert.ToInt32(w);
                realresult[k].imgHeight = Convert.ToInt32(h);
                realresult[k].marginleft = Convert.ToInt32(marginleft);
                realresult[k].left = Convert.ToInt32(left);
                realresult[k].top = Convert.ToInt32(top);
                left += 295;
                double doublek = k;
                double blapke = doublek / 3;
                if (blapke== 1) {
                    left = 0;
                }
                
            }return realresult;
                
        }

    }
}