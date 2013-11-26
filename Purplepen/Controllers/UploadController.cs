using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Purplepen.Controllers
{
    public class UploadController : Controller
    {
        //
        // GET: /Upload/
 public ActionResult Upload()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        // This action handles the form POST and the upload
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {

            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                var fileName = Path.GetFileName(file.FileName);
                // extract file extension
                var fileExtension = Path.GetExtension(fileName);
                if(fileExtension==".jpg" || fileExtension==".JPG" || fileExtension=="jpeg" || fileExtension=="JPEG" || fileExtension==".gif" || fileExtension==".png"){
                    //get datetime
                    String now=DateTime.Now.ToString("yyyy");
                    now += DateTime.Now.ToString("MM");
                    now += DateTime.Now.ToString("dd");
                    now += DateTime.Now.ToString("HH");
                    now += DateTime.Now.ToString("mm");
                    now += DateTime.Now.ToString("ss");
                    // store the file inside ~/App_Data/uploads folder
                    var path = Path.Combine(Server.MapPath("~/App_Data/uploads/"), now+fileName);
                    file.SaveAs(path);
                    // redirect back to the index action to show the form once again
                    return RedirectToAction("Upload");
                }
                
            }
return RedirectToAction("Error");
        }

    }
}
