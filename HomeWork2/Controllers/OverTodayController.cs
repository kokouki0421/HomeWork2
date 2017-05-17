using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork2.Controllers
{
    public class OverTodayController : Controller
    {
        // GET: OverToday
        public ActionResult OverToday(DateTime? Dateee)
        {
            var result = true; 
            if (Dateee.HasValue)
            {
                result = Dateee < DateTime.Now.Date;
            }
            return Json(result,JsonRequestBehavior.AllowGet);
        }
       
    }
}