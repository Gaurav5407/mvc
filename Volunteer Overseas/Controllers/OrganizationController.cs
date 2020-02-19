using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Volunteer_Overseas.Class;
using Volunteer_Overseas.Models;
using PagedList;

namespace Volunteer_Overseas.Controllers
{
    public class OrganizationController : Controller
    {
        private gauravEntities context = new gauravEntities();
        // GET: Organization
        public ActionResult Project()
        {
            return View();
        }

    }
}