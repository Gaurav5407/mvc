using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Volunteer_Overseas.Models;

namespace Volunteer_Overseas.Class
{
    public class OrganizationDataOperation
    {
        public List<usp_getAllOrganizations_Result> GetOrganizationRecords()
        {
            using (gauravEntities context = new gauravEntities())
            {
                return context.GetOrganizations().ToList();
            }
        }

    }
}