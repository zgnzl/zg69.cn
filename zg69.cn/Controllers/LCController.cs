using _69zg.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zg69.cn.Controllers
{
    public class LCController : ILController
    {
        
        public ActionResult Img(string pwd)
        {
            if (pwd != "0474")
                return RedirectToAction("Index");
            return View();
        }

        public ActionResult UploadFile()
        {
            if (RequestUtil.GetValue("niezl") != "niezl")
            {
                return new EmptyResult();
            }
            if (Request.Files.Count > 0)
            {
                Request.Files[0].SaveAs(Server.MapPath("~/Files/" + Request.Files[0].FileName));
                return ObjResult(true, "上传成功");
            }
            else
                return View();
        }
    }
}