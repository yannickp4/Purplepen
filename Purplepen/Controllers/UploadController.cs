﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Purplepen.Models;

namespace Purplepen.Controllers
{
    public class UploadController : Controller
    {
        //
        // GET: /Upload/
        public ActionResult Upload()
        {
            Upload u = new Upload();
            Int64 blip = Convert.ToInt64(Session["fbID"]);
            ViewBag.allProjects = u.allProjects(blip);//session id
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        // This action handles the form POST and the upload
        [HttpPost]
        public ActionResult ImageUpload(HttpPostedFileBase file, FormCollection form)
        {

            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                var fileName = Path.GetFileName(file.FileName);
                // extract file extension
                var fileExtension = Path.GetExtension(fileName);
                if (fileExtension == ".jpg" || fileExtension == ".JPG" || fileExtension == "jpeg" || fileExtension == "JPEG" || fileExtension == ".gif" || fileExtension == ".GIF"  || fileExtension == ".png" || fileExtension == ".PNG")
                {
                    //get datetime
                    String now = DateTime.Now.ToString("yyyy");
                    now += DateTime.Now.ToString("MM");
                    now += DateTime.Now.ToString("dd");
                    now += DateTime.Now.ToString("HH");
                    now += DateTime.Now.ToString("mm");
                    now += DateTime.Now.ToString("ss");
                    // store the file inside ~/App_Data/uploads folder
                    var path = Path.Combine(Server.MapPath("~/uploads/"), now + fileName);
                    file.SaveAs(path);
                    //save into database
                    project p = new project();
                    uploadversion u = new uploadversion();
                    p.user_id = Convert.ToInt64(Session["fbID"]);
                    var blap = form["project_id"];
                    if (form["project_id"] != null)
                    {
                        p.project_id = Convert.ToInt32(form["project_id"]);
                        u.project_id = Convert.ToInt32(form["project_id"]);
                    }
                    else
                    {
                        //check if title already exist
                        p.name = form["txtTitle"];
                        u.version_id = 0;
                    }
                    u.path = now + fileName;
                    u.description = form["txtDescription"];
                    u.datum = DateTime.Now;
                    Upload uploadimage = new Upload();
                    uploadimage.uploadimage(u, p);
                    // redirect back to the index action to show the form once again
                    return RedirectToAction("Upload");
                }

            }
            return RedirectToAction("Error");
        }

    }
}
