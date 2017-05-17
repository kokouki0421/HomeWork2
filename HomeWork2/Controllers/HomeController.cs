using HomeWork2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();

        }
        [ChildActionOnly]
        public ActionResult View1()
        {
            var model = new List<MyClassModel>();
            var db = new Model1().AccountBook.ToList();
            foreach (var item in db)
            {
                if (item.Categoryyy == 0)
                {

                    model.Add(
                        new MyClassModel()
                        {
                            Category = "收入",
                            Date = item.Dateee,
                            Money = item.Amounttt,
                            Remark = item.Remarkkk
                        }
                    );

                }
                if (item.Categoryyy == 1)
                {

                    model.Add(
                           new MyClassModel()
                           {
                               Category = "支出",
                               Date = item.Dateee,
                               Money = item.Amounttt,
                               Remark = item.Remarkkk
                           }
                       );

                }
            }
            return View(model);
        }
        private Model1 db = new Model1();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Id,Categoryyy,Amounttt,Dateee,Remarkkk")] AccountBook accountBook)
        {
            if (ModelState.IsValid)
            {
                accountBook.Id = Guid.NewGuid();
                db.AccountBook.Add(accountBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountBook);
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