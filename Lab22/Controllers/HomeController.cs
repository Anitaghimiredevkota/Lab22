using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab22.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Register()
        {
            return View();
        }
        //public ActionResult GetUserinfo(string firstname,string lastname,string email,string phonenumber,string password)
        //{
        //    ViewBag.firstname = firstname;
        //    ViewBag.lastname = lastname;
        //    ViewBag.email = email;
        //    ViewBag.phonenumber = phonenumber;
        //    ViewBag.password = password;

        //    return View("SummaryPage");

        //}
        //public ActionResult SummaryPage()
        //{
        //    return View();
        //}
       public ActionResult SummaryPage(string firstname,string lastname, string email,string phonenumber, string password)
        {
            Models.User user = new Models.User();
            user.Firstname = firstname;
            user.Lastname = lastname;
            user.Email = email;
            user.Phonenumber = phonenumber;
            user.Password = password;
            return View(user);
        }
        
    }
}