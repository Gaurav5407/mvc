using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volunteer_Overseas.Class;

namespace Volunteer_Overseas.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Login()
        {
            return View();
        }
        
        public ActionResult ProjectList()
        {
            ProjectDataOperation project = new ProjectDataOperation();
            return View(project.GetProjectRecord());
        }
        public ActionResult OrganizationList()
        {
            OrganizationDataOperation organization = new OrganizationDataOperation();
            return View(organization.GetOrganizationRecords());
        }

    }
}