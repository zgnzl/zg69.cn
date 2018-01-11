using _69zg.Common;
using _69zg.DataContent;
using System.Collections.Generic;
using System.Web.Mvc;
using ZG69.Model;

namespace zg69.cn.Controllers
{
    public class HomeController : Controller

    {
        public ActionResult Index()
        {
           string city= ResquestUtil.GetIpCity("101.54.63.4");
           List<T_region> regions= DB.Context.From<T_region>().Where(c => c.Pinyin.Equals(city, System.StringComparison.CurrentCultureIgnoreCase)).ToList() ;
            string cityname = "世外桃源";
            if (regions.Count > 0)
                cityname = regions[0].ShortName;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}