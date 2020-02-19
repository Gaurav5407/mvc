using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Volunteer_Overseas.Class;
using Volunteer_Overseas.Models;
using Volunteer_Overseas.Model;

namespace Volunteer_Overseas.Controllers
{
    public class CategoriesController : Controller
    {
        private gauravEntities db = new gauravEntities();

        // GET: Categories
        public ActionResult Category(int? pagenumber)
        {
            CategoryDataOperation category = new CategoryDataOperation();
            CategoryMetadata cCategory = new CategoryMetadata();
            //cCategory.pagination = category.GetCategoryRecord().ToPagedList(pagenumber ?? 1, 10);

            List<csp_getTypes_Result> lstCSP_getTypes_Result = category.GetCategoryRecord();
            List<CategoryMetadata> lstCustomCategoryMetadata = new List<CategoryMetadata>();

            foreach (csp_getTypes_Result csp_getTypes_Result in lstCSP_getTypes_Result)
            {
                CategoryMetadata customCategoryMetadata = new CategoryMetadata
                {
                    id = csp_getTypes_Result.Id,
                    category_name = csp_getTypes_Result.Name
                };

                lstCustomCategoryMetadata.Add(customCategoryMetadata);
            }

            return View(category.GetCategoryRecord());
        }

        // GET: Categories/Details/5
       
        // GET: Categories/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Add([Bind(Include = "id,category_name")] Category category)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Categories.Add(category);
        //        db.SaveChanges();
        //        return RedirectToAction("Category");
        //    }

        //    return View(category);
        //}

        // GET: Categories/Edit/5
        public ActionResult EditCategory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCategory([Bind(Include = "id,category_name")] CategoryMetadata categoryMetadata)
        {
            if (ModelState.IsValid)
            {
                Models.Category category = new Models.Category();
                category.category_name = categoryMetadata.category_name;
                //db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Category");
            }
            return View(categoryMetadata);
        }

        // GET: Categories/Delete/5
        

        // POST: Categories/Delete/5

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
