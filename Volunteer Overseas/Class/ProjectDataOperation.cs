using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Volunteer_Overseas.Models;

namespace Volunteer_Overseas.Class
{
    public class ProjectDataOperation
    {
        public List<usp_getAllProjects_Result> GetProjectRecord()
        {
            gauravEntities context = new gauravEntities();
            
                return context.GetProjects(0).ToList();
           
        }
    }
}