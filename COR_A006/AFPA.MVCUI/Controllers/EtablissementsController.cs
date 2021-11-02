using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AFPA.BOL;
using AFPA.DAL;

namespace AFPA.MVCUI.Controllers
{
    public class EtablissementsController : Controller
    {
        private AFPA_ORMEntities db = new AFPA_ORMEntities();

        // GET: Etablissements
        public ActionResult Index()
        {
            var etablissement = db.Etablissement.
                Include(e => e.EtablissementRattachement);
            return View(etablissement.ToList());
        }

        // GET: Etablissements/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Etablissement etablissement = db.Etablissement.Find(id);
            if (etablissement == null)
            {
                return HttpNotFound();
            }
            return View(etablissement);
        }

        // GET: Etablissements/Create
        public ActionResult Create()
        {
            ViewBag.IdEtablissementRattachement = new SelectList(db.Etablissement, "IdEtablissement", "DesignationEtablissement");
            return View();
        }

        // POST: Etablissements/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEtablissement,DesignationEtablissement,IdEtablissementRattachement,Adresse")] Etablissement etablissement)
        {
            if (ModelState.IsValid)
            {
                db.Etablissement.Add(etablissement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEtablissementRattachement = new SelectList(db.Etablissement, "IdEtablissement", "DesignationEtablissement", etablissement.IdEtablissementRattachement);
            return View(etablissement);
        }

        // GET: Etablissements/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Etablissement etablissement = db.Etablissement.Find(id);
            if (etablissement == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEtablissementRattachement = new SelectList(db.Etablissement, "IdEtablissement", "DesignationEtablissement", etablissement.IdEtablissementRattachement);
            return View(etablissement);
        }

        // POST: Etablissements/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEtablissement,DesignationEtablissement,IdEtablissementRattachement,Adresse")] Etablissement etablissement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(etablissement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEtablissementRattachement = new SelectList(db.Etablissement, "IdEtablissement", "DesignationEtablissement", etablissement.IdEtablissementRattachement);
            return View(etablissement);
        }

        // GET: Etablissements/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Etablissement etablissement = db.Etablissement.Find(id);
            if (etablissement == null)
            {
                return HttpNotFound();
            }
            return View(etablissement);
        }

        // POST: Etablissements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Etablissement etablissement = db.Etablissement.Find(id);
            db.Etablissement.Remove(etablissement);
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
