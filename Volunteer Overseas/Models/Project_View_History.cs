//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Volunteer_Overseas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project_View_History
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public int user_id { get; set; }
        public Nullable<System.DateTime> view_date { get; set; }
    
        public virtual Project Project { get; set; }
    }
}