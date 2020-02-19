using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volunteer_Overseas.Class;
using Volunteer_Overseas.Models;

namespace Volunteer_Overseas.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Index page";
            return View();
        }

        public ActionResult Faq()
        {
            ViewBag.Message = "Faq page";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Inquiry inquiryData)
        {
            ViewBag.Message = "Your contact page.";
            ContactDataOperation contact = new ContactDataOperation();
            if (contact.InsertContact(inquiryData))
            {
                ViewBag.status = " added sussessfully";
            }
            else
            {
                ViewBag.status = " added not sussessfully";
            }
            return View();

        }
        public ActionResult Home()
        {
            ViewBag.Message = "Home page";
            return View();
        }
        public ActionResult Search()
        {
            ViewBag.Message = "Search page";
            return View();
        }
        public ActionResult Work()
        {
            ViewBag.Message = "Work page";
            return View();
        }
    }
}