using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AFPA.DAL;
using AFPA.BOL;
using System.Net;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AFPA.MVCUI.Models;
using System.Web.UI;
using AFPA.MVCUI.Complements;
using System.Threading;

namespace AFPA.MVCUI.Controllers
{
    public class OffreFormationsController : Controller
    {
        private AFPA_ORMEntities db = new AFPA_ORMEntities();

        public OffreFormationsController()
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;
        }
       
        public ActionResult ListeFormations(string idProduitFormation)
        {
            var offreFormation = db.OffreFormation.Include(o => o.FormateurReferent).
                Include(o => o.Etablissement).Include(o => o.ProduitDeFormation).
                Where(o => o.IdProduitFormation == idProduitFormation);
            return PartialView("ListeOffres", offreFormation.ToList());

        }
        public JsonResult ListeFormationsJson(string idProduitFormation)
        {
            var offreFormation = db.OffreFormation.Include(o => o.FormateurReferent).
                Include(o => o.Etablissement).Include(o => o.ProduitDeFormation).
                Where(o => o.IdProduitFormation == idProduitFormation)
                .Select(o =>
                      new
                {
                    dateDebut = o.DateDebutOffreFormation,
                    dateFin = o.DateFinOffreFormation,
                    matriculeCollaborateur = (o.FormateurReferent.MatriculeCollaborateurAfpa == null)
                    ? "Non affectée" : o.FormateurReferent.MatriculeCollaborateurAfpa,
                    etablissement = o.Etablissement.DesignationEtablissement,
                    produit = o.ProduitDeFormation.DesignationProduitFormation,
                    idOffre = o.IdOffreFormation,
                    idEtablissement = o.IdEtablissement

                }).ToList();

           
            var result = from o in offreFormation
                         select new object[] { 
                           o.dateDebut.ToShortDateString(), 
                          o.dateFin.ToShortDateString(), 
                          o.matriculeCollaborateur,
                           o.etablissement,
                         o.produit,
                         string.Format("idOffre={0}&idEtablissement={1}",o.idOffre,o.idEtablissement)
                         };
                        


            return Json(new
            {
                iTotalRecords = result.Count(),
                iDisplayStart =1,
                iTotalDisplayRecords = result.Count(),
                aaData = result
            },
        JsonRequestBehavior.AllowGet);


        }
        // GET: OffreFormations

        public ActionResult Index()
        {
            //    var offreFormation = db.OffreFormation.Include(o => o.FormateurReferent).Include(o => o.Etablissement).Include(o => o.ProduitDeFormation);

            return View();
        }
        public ActionResult IndexJson()
        {
            //    var offreFormation = db.OffreFormation.Include(o => o.FormateurReferent).Include(o => o.Etablissement).Include(o => o.ProduitDeFormation);

            return View();
        }

        // GET: OffreFormations/Details/5
        [OutputCache(Duration = 20, VaryByParam = "idOffre;idEtablissement", Location = OutputCacheLocation.Client)]
        // [OutputCache(Duration = 20, VaryByParam = "idOffre;idEtablissement")]
        public ActionResult Details(int? idOffre, string idEtablissement)
        {
            if (idOffre == null || idEtablissement == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OffreFormation offreFormation = db.OffreFormation.Find(new object[] { idOffre, idEtablissement });
            if (offreFormation == null)
            {
                return HttpNotFound();
            }
            return View(offreFormation);
        }
        // GET: OffreFormations/Create
        public ActionResult Create()
        {
            ViewBag.IdPersonne = new SelectList(db.CollaborateursAfpa, "IdPersonne", "MatriculeCollaborateurAfpa");
            ViewBag.IdEtablissement = new SelectList(db.Etablissement, "IdEtablissement", "DesignationEtablissement");
            ViewBag.IdProduitFormation = new SelectList(db.ProduitDeFormation, "IdProduitFormation", "DesignationProduitFormation");
            return View();
        }

        // POST: OffreFormations/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        [TracerExceptionsV1]
        [HandleError(ExceptionType = typeof(System.Data.Entity.Infrastructure.DbUpdateException), View = "ErreurSQL")]
        public ActionResult Create([Bind(Include = "IdOffreFormation,IdEtablissement,DateDebutOffreFormation,DateFinOffreFormation,IdPersonne,IdProduitFormation")] OffreFormation offreFormation)
        {
            if (ModelState.IsValid)
            {
                db.OffreFormation.Add(offreFormation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdPersonne = new SelectList(db.CollaborateursAfpa, "IdPersonne", "MatriculeCollaborateurAfpa", offreFormation.IdPersonne);
            ViewBag.IdEtablissement = new SelectList(db.Etablissement, "IdEtablissement", "DesignationEtablissement", offreFormation.IdEtablissement);
            ViewBag.IdProduitFormation = new SelectList(db.ProduitDeFormation, "IdProduitFormation", "DesignationProduitFormation", offreFormation.IdProduitFormation);
            return View(offreFormation);
        }
        /// <summary>
        /// Création d'une liste de produits de formation à partir d'un code produit partiel.
        /// </summary>
        /// <param name="Recherche">Partie du code à rechercher</param>
        /// <returns></returns>

        public JsonResult CodeProduitPartialResult(string term)
        {
            var ProduitsFormation = db.ProduitsQualifiant.Where(p => p.IdProduitFormation.Contains(term))
                .Select(p =>
                new
                {
                    id = p.IdProduitFormation,
                    label = p.DesignationProduitFormation,
                    value = p.IdProduitFormation
                });

            return Json(ProduitsFormation, JsonRequestBehavior.AllowGet);


        }

        /// <summary>
        /// Création d'une liste de produits de formation à partir d'un libellé partiel.
        /// </summary>
        /// <param name="Recherche">Partie du libellé à rechercher</param>
        /// <returns></returns>

        public JsonResult DesignationProduitPartialResult(string term)
        {
            var ProduitsFormation = db.ProduitsQualifiant.Where(p => p.DesignationProduitFormation.Contains(term))
                .Select(p =>
                new
                {
                    id = p.IdProduitFormation,
                    label = p.DesignationProduitFormation,
                    value = p.IdProduitFormation
                });

            return Json(ProduitsFormation.ToList(), JsonRequestBehavior.AllowGet);
        }
        // GET: OffreFormations/Edit/5
        public ActionResult Edit(int? idOffre, string idEtablissement)
        {
            if (idOffre == null && idEtablissement == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            OffreFormation offreFormation = db.OffreFormation.Find(new object[] { idOffre, idEtablissement });
            if (offreFormation == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdPersonne = new SelectList(db.CollaborateursAfpa, "IdPersonne", "MatriculeCollaborateurAfpa", offreFormation.IdPersonne);
            ViewBag.IdEtablissement = new SelectList(db.Etablissement, "IdEtablissement", "DesignationEtablissement", offreFormation.IdEtablissement);
            ViewBag.IdProduitFormation = new SelectList(db.ProduitDeFormation, "IdProduitFormation", "DesignationProduitFormation", offreFormation.IdProduitFormation);
            return View(offreFormation);
        }

        // POST: OffreFormations/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdOffreFormation,IdEtablissement,DateDebutOffreFormation,DateFinOffreFormation,IdPersonne,IdProduitFormation")] OffreFormation offreFormation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(offreFormation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdPersonne = new SelectList(db.CollaborateursAfpa, "IdPersonne", "MatriculeCollaborateurAfpa", offreFormation.IdPersonne);
            ViewBag.IdEtablissement = new SelectList(db.Etablissement, "IdEtablissement", "DesignationEtablissement", offreFormation.IdEtablissement);
            ViewBag.IdProduitFormation = new SelectList(db.ProduitDeFormation, "IdProduitFormation", "DesignationProduitFormation", offreFormation.IdProduitFormation);
            return View(offreFormation);
        }

        // GET: OffreFormations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OffreFormation offreFormation = db.OffreFormation.Find(id);
            if (offreFormation == null)
            {
                return HttpNotFound();
            }
            return View(offreFormation);
        }

        // POST: OffreFormations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OffreFormation offreFormation = db.OffreFormation.Find(id);
            db.OffreFormation.Remove(offreFormation);
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
