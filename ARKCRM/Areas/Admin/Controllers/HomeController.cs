using ARKCRM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARKCRM.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        ArkcrmContext db = new ArkcrmContext();
        public ActionResult Index()
        {

            return View();
        }
      
        public ActionResult PartialIndex(string tableName) 
        {
             



            return View();
        }
    }
}