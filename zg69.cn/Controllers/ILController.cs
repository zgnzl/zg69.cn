using _69zg.DataContent;
using System.Collections.Generic;
using System.Web.Mvc;
using ZG69.Model;

namespace zg69.cn.Controllers
{
    public  class ILController : Controller
    {
        // GET: IL
        public ActionResult Index()
        {
            return View();
        }

        protected  string ConvertPinYinToHanZi( string pinyin)
        {
            List<T_region> regions = DB.Context.From<T_region>().Where(c => c.Pinyin.Equals(pinyin, System.StringComparison.CurrentCultureIgnoreCase)).ToList();
            if (regions.Count > 0)
               return  regions[0].ShortName;
            return "世外桃源";
        }
    }
}