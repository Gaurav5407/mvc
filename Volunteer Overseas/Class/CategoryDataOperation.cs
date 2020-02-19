using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Volunteer_Overseas.Models;
using System.Data.Entity.Core.Objects;
using PagedList;
using Volunteer_Overseas.Model;

namespace Volunteer_Overseas.Class
{
    public class CategoryDataOperation
    {
        public List<csp_getTypes_Result> GetCategoryRecord()
        {
            using (gauravEntities context = new gauravEntities())
            {
                return context.GetCategory().ToList();
            }
        }
    }
}