using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dinamik_Tablo.Controllers
{
    public class DataController : Controller
    {
        DataManager dataManager = new DataManager(new EfDataDal()); 
        // GET: Data
        [HttpGet]
        public ActionResult FormView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FormView(Data data)
        {
            dataManager.AddData(data);
            return View();
        }
    }
}