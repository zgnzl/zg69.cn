using _69zg.Common;
using _69zg.DataContent;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ZG69.Model;

namespace zg69.cn.Controllers
{
    public  class ILController : Controller
    {
        // GET: IL
        protected static string ip = RequestUtil.GetIP();
        protected static string pinyincity = RequestUtil.GetIpCity(ip);

        public void Init()
        {
            T_visitor model = new T_visitor();
            model.City = pinyincity;
            model.IP = ip;
            model.PageUrl = Request.UrlReferrer==null?Request.Url.OriginalString:Request.UrlReferrer.AbsolutePath;
            model.Date = DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分ss秒");
            DB.Context.Insert<T_visitor>(model);
        }

        public ActionResult Index()
        {
            Init();
            string cityname = ConvertPinYinToHanZi(pinyincity);
            ViewBag.cityname = cityname;
            ViewBag.ip = ip;
            return View();
        }

        protected  string ConvertPinYinToHanZi( string pinyin)
        {
            List<T_region> regions = DB.Context.From<T_region>().Where(c => c.Pinyin.Equals(pinyin, System.StringComparison.CurrentCultureIgnoreCase)).ToList();
            if (regions.Count > 0)
               return  regions[0].ShortName;
            return "世外桃源";
        }

        public ActionResult ObjResult(bool result, object message)
        {
            return Json(new {
                result= result,
                message= message
            },JsonRequestBehavior.AllowGet);
        }
    }
}