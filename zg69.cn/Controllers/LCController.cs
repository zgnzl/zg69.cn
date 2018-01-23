using _69zg.Common;
using _69zg.DataContent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using zg69.cn.Models;
using ZG69.Model;
using System.IO;

namespace zg69.cn.Controllers
{
    public class LCController : ILController
    {
        public override ActionResult Index()
        {
            DataTable dt = DB.Context.FromSql("SELECT count(*) AS Count ,City from T_visitor group BY City order by Count desc ").ToDataTable();
            StringBuilder sb = new StringBuilder();
            sb.Append("当前访问：");
            foreach (DataRow dr in dt.Rows)
            {
                sb.AppendFormat("{0}<span style='color:black'>{1}</span>人，", ConvertPinYinToHanZi(dr["City"].ToString() == "" ? "外太空" : dr["City"].ToString()), dr["Count"].ToString());
            }
            ViewBag.models = sb.ToString().TrimEnd('，');
            return base.Index();
        }

        public ActionResult Img(string pwd)
        {
            string view = "";
            switch (pwd)
            {
                case "0474": view = "Img"; break;
                case "010":
                    view = "Img010";
                    DirectoryInfo directoryInfo = new DirectoryInfo(Server.MapPath("~/IMG/LC/20180120"));
                    List<string> filelist = new List<string>();
                    foreach (FileInfo info in directoryInfo.GetFiles())
                    {
                        if (".jpg,.jpeg,.bmp".Contains(info.Extension))
                        {
                            filelist.Add(info.Name);
                        }
                    }
                    ViewBag.filelist = filelist;
                    ViewBag.isfile = false;
                    break;
            }
            if (string.IsNullOrEmpty(view))
                return RedirectToAction("Index");
            return View(view);
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