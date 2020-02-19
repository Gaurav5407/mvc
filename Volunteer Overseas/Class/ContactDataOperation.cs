using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using Volunteer_Overseas.Models;

namespace Volunteer_Overseas.Class
{
    public class ContactDataOperation
    {
        public bool InsertContact(Inquiry inquiryData)
        {
            using (gauravEntities context = new gauravEntities())
            {
                ObjectParameter addConfirmation = new ObjectParameter("AddConfirmation", typeof(int));
                context.AddInquiry
                    (
                    inquiryData.name,
                    inquiryData.email_id,
                    inquiryData.message,
                    addConfirmation
                    );
                context.SaveChanges();
                if (Convert.ToInt32(addConfirmation.Value) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}