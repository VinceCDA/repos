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
    public class ProduitDeFormationController : Controller
    {
        private AFPA_ORMEntities db = new AFPA_ORMEntities();

        // GET: ProduitDeFormation
        public ActionResult Index()
        {
            return View(db.ProduitDeFormation.ToList());
        }

        // GET: ProduitDeFormation/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProduitDeFormation produitDeFormation = db.ProduitDeFormation.Find(id);
            if (produitDeFormation == null)
            {
                return HttpNotFound();
            }
            return View(produitDeFormation);
        }

        // GET: ProduitDeFormation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduitDeFormation/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdProduitFormation,DesignationProduitFormation")] ProduitDeFormation produitDeFormation)
        {
            if (ModelState.IsValid)
            {
                db.ProduitDeFormation.Add(produitDeFormation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produitDeFormation);
        }

        // GET: ProduitDeFormation/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProduitDeFormation produitDeFormation = db.ProduitDeFormation.Find(id);
            if (produitDeFormation == null)
            {
                return HttpNotFound();
            }
            return View(produitDeFormation);
        }

        // POST: ProduitDeFormation/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdProduitFormation,DesignationProduitFormation")] ProduitDeFormation produitDeFormation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produitDeFormation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produitDeFormation);
        }

        // GET: ProduitDeFormation/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProduitDeFormation produitDeFormation = db.ProduitDeFormation.Find(id);
            if (produitDeFormation == null)
            {
                return HttpNotFound();
            }
            return View(produitDeFormation);
        }

        // POST: ProduitDeFormation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ProduitDeFormation produitDeFormation = db.ProduitDeFormation.Find(id);
            db.ProduitDeFormation.Remove(produitDeFormation);
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
