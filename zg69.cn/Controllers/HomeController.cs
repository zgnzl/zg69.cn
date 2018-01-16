using _69zg.Common;
using _69zg.DataContent;
using System.Collections.Generic;
using System.Web.Mvc;
using ZG69.Model;

namespace zg69.cn.Controllers
{
    public class HomeController : ILController

    {

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

        public ActionResult MessageToUs(T_leavewords models)
        {
            models.UserIP = ip;
            models.UserCity = pinyincity;
            if (DB.Context.Insert<T_leavewords>(models) > 0)
                return ObjResult(true, "我们已收到您的消息，感谢您的支持!");
            else
            {
                return ObjResult(false, "服务器正在维护，暂时无法收到您的消息，请稍后再试，感谢您的支持！");
            }
        }
    }
}