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
    public class HeaderController : Controller
    {
        DataManager dataManager = new DataManager(new EfDataDal());
        HeaderManager headerManager = new HeaderManager(new EfHeaderDal());
        // GET: Header
        public ActionResult TableView()
        {
            var tableview = headerManager.GetHeaders();
            return View(tableview);
        }
        [HttpGet]
        public ActionResult AddHeaders()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddHeaders(Header header)
        {
            headerManager.AddHeader(header);    
            return View();
        }
        public ActionResult DeleteHeaders(int id)
        {
            var header = headerManager.GetbyID(id);
            headerManager.DeleteHeader(header);
            return View();
        }
    }
}