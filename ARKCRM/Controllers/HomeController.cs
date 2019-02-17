using ARKCRM.DAL;
using ARKCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ARKCRM.Controllers
{
    public class HomeController : Controller
    {
        ArkcrmContext db = new ArkcrmContext();
        public ActionResult Index()

        {

            
            return View();
        }


        [HttpPost]
        public ActionResult Index(User _user){

          User user=  db.Users.SingleOrDefault(x=>x.UserName==_user.UserName && x.Password==_user.Password);
            if (user != null)
            {
                Session["Id"] = user.Id;
                Session["UserName"] = user.UserName;
                Session["Password"] = user.Password;
                Session["Authority"] = user.Authority;
                Session["UserPages"] = user.UserPages;
                Session["ClientId"]=user.ClientId;

                if (user.Authority== 1)
                {
                    return RedirectToAction("Index","Home",new { area="Admin"});
                }
                

            } 
            


                       
            return  View();
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