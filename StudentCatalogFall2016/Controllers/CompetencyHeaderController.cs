using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentCatalogFall2016.Models;
using StudentCatalogFall2016.Models.Entity;

namespace StudentCatalogFall2016.Controllers
{
    public class CompetencyHeaderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CompetencyHeader
        public ActionResult Index()
        {
            return View(db.CompentencyHeaderModels.ToList());
        }

        // GET: CompetencyHeader/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompetencyHeaderModel competencyHeaderModel = db.CompentencyHeaderModels.Find(id);
            if (competencyHeaderModel == null)
            {
                return HttpNotFound();
            }
            return View(competencyHeaderModel);
        }

        // GET: CompetencyHeader/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompetencyHeader/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompetencyHeaderModelId,Name")] CompetencyHeaderModel competencyHeaderModel)
        {
            if (ModelState.IsValid)
            {
                db.CompentencyHeaderModels.Add(competencyHeaderModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(competencyHeaderModel);
        }

        // GET: CompetencyHeader/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompetencyHeaderModel competencyHeaderModel = db.CompentencyHeaderModels.Find(id);
            if (competencyHeaderModel == null)
            {
                return HttpNotFound();
            }
            return View(competencyHeaderModel);
        }

        // POST: CompetencyHeader/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompetencyHeaderModelId,Name")] CompetencyHeaderModel competencyHeaderModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(competencyHeaderModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(competencyHeaderModel);
        }

        // GET: CompetencyHeader/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompetencyHeaderModel competencyHeaderModel = db.CompentencyHeaderModels.Find(id);
            if (competencyHeaderModel == null)
            {
                return HttpNotFound();
            }
            return View(competencyHeaderModel);
        }

        // POST: CompetencyHeader/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompetencyHeaderModel competencyHeaderModel = db.CompentencyHeaderModels.Find(id);
            db.CompentencyHeaderModels.Remove(competencyHeaderModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
