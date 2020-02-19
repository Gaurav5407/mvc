using System.Collections.Generic;
using Volunteer_Overseas.Models;
using PagedList;
using System.ComponentModel.DataAnnotations;
using Volunteer_Overseas.Class;

namespace Volunteer_Overseas.Model
{
    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {
        
    }

    public class CategoryMetadata
    {
        public CategoryMetadata()
        {
            this.Projects = new HashSet<Project>();
        }
        public int id { get; set; }
        public string category_name { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
      
        public IPagedList<Category> pagination { get; set; }
    }
}