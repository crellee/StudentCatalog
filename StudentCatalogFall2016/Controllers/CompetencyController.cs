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
    public class CompetencyController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Competency
        public ActionResult Index()
        {
            var compentencyMocdels = db.CompentencyMocdels.Include(c => c.CompetencyHeader);
            return View(compentencyMocdels.ToList());
        }

        // GET: Competency/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompetencyModel competencyModel = db.CompentencyMocdels.Find(id);
            if (competencyModel == null)
            {
                return HttpNotFound();
            }
            return View(competencyModel);
        }

        // GET: Competency/Create
        public ActionResult Create()
        {
            ViewBag.CompetencyHeaderModelId = new SelectList(db.CompentencyHeaderModels, "CompetencyHeaderModelId", "Name");
            return View();
        }

        // POST: Competency/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompetencyModelId,Name,CompetencyHeaderModelId")] CompetencyModel competencyModel)
        {
            if (ModelState.IsValid)
            {
                db.CompentencyMocdels.Add(competencyModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompetencyHeaderModelId = new SelectList(db.CompentencyHeaderModels, "CompetencyHeaderModelId", "Name", competencyModel.CompetencyHeaderModelId);
            return View(competencyModel);
        }

        // GET: Competency/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompetencyModel competencyModel = db.CompentencyMocdels.Find(id);
            if (competencyModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompetencyHeaderModelId = new SelectList(db.CompentencyHeaderModels, "CompetencyHeaderModelId", "Name", competencyModel.CompetencyHeaderModelId);
            return View(competencyModel);
        }

        // POST: Competency/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompetencyModelId,Name,CompetencyHeaderModelId")] CompetencyModel competencyModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(competencyModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompetencyHeaderModelId = new SelectList(db.CompentencyHeaderModels, "CompetencyHeaderModelId", "Name", competencyModel.CompetencyHeaderModelId);
            return View(competencyModel);
        }

        // GET: Competency/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompetencyModel competencyModel = db.CompentencyMocdels.Find(id);
            if (competencyModel == null)
            {
                return HttpNotFound();
            }
            return View(competencyModel);
        }

        // POST: Competency/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompetencyModel competencyModel = db.CompentencyMocdels.Find(id);
            db.CompentencyMocdels.Remove(competencyModel);
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
