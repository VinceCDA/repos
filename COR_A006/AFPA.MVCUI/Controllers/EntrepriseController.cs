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
    public class EntrepriseController : Controller
    {
        private AFPA_ORMEntities db = new AFPA_ORMEntities();

        // GET: Entreprise
        public ActionResult Index()
        {
            return View(db.Entreprise.ToList());
        }

        // GET: Entreprise/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise entreprise = db.Entreprise.Find(id);
            if (entreprise == null)
            {
                return HttpNotFound();
            }
            return View(entreprise);
        }

        // GET: Entreprise/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entreprise/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEntreprise,NumeroSIRET,RaisonSociale,Adresse")] Entreprise entreprise)
        {
            if (ModelState.IsValid && ValidationPersonnalisee(entreprise,ModelState))
            {
                db.Entreprise.Add(entreprise);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entreprise);
        }

        // GET: Entreprise/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise entreprise = db.Entreprise.Find(id);
            if (entreprise == null)
            {
                return HttpNotFound();
            }
            return View(entreprise);
        }

        // POST: Entreprise/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEntreprise,NumeroSIRET,RaisonSociale,Adresse")] Entreprise entreprise)
        {
          if (ModelState.IsValid && ValidationPersonnalisee(entreprise,ModelState))
            {            
                db.Entry(entreprise).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entreprise);
        }

        // GET: Entreprise/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entreprise entreprise = db.Entreprise.Find(id);
            if (entreprise == null)
            {
                return HttpNotFound();
            }
            return View(entreprise);
        }

        // POST: Entreprise/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entreprise entreprise = db.Entreprise.Find(id);
            db.Entreprise.Remove(entreprise);
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

        public bool ValidationPersonnalisee(Entreprise model, ModelStateDictionary modelState)
        {
            bool OK = true;
            if (string.IsNullOrEmpty(model.Adresse.NumeroNomVoie))
            {
                modelState.AddModelError("Adresse.NumeroNomVoie", "Les informations numéro et nom de voie sont requises");
               OK=false;
            }
            if (string.IsNullOrEmpty(model.Adresse.CodePostal))
            {
                modelState.AddModelError("Adresse.CodePostal", "Le code postal est requis");
                OK = false;
            }
            if (string.IsNullOrEmpty(model.Adresse.Ville))
            {
                modelState.AddModelError("Adresse.Ville", "La ville est requise");
                OK = false;
            }
            return OK;
        }
    }
}
