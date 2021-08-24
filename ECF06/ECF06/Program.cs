using ECF06.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECF06
{
    class Program
    {

        static void Main()
        {
            using (ORM2020 dbContext = new ORM2020())
            {
                Req_Test(dbContext);
                Req_01_RechercheStagiairesByCaracteres(dbContext, "boc");
                Req_02_RechercheEntrepriseBySiret(dbContext, "70204275500281");
                Req_03_ListeStagiaires(dbContext, 8495, "19011");
                Req_04_VolumesParAnneeEtablissement(dbContext, 2018, "19011");
                Req_05_StagiairesDemissionnairesParAnneeEtablissement(dbContext, 2018, "19011");
                Req_06_TauxDepartAnticipeParAnneeEtablissement(dbContext, 2018, "19011");
                Req_07_ListeTiersEntrepriseBySiret(dbContext, "70204275500281");
            }
            Console.Read();
        }

        private static void Req_Test(ORM2020 dbContexte)
        {

            Console.WriteLine("\r\nTests Impression\r\n");
            Console.WriteLine("\r\nImpression objet\r\n");
            var unique = dbContexte.ProduitQualifiant.First();
            ObjectDumper.Write(unique);
            Console.WriteLine("\r\nImpression Liste objets\r\n");
            var listeProduitQualifiant = dbContexte.
                ProduitQualifiant.Where(p => p.NiveauFormation < 4);
            ObjectDumper.Write(listeProduitQualifiant);
            Console.WriteLine("\r\nImpression Projection Liste\r\n");
            var listestagiaires = dbContexte.
                Stagiaire.Where(s=>s.SexePersonne==1 && s.PrenomPersonne.Contains("vi")).ToList();
                
            ObjectDumper.Write(listestagiaires);
        }

        public static void Req_01_RechercheStagiairesByCaracteres(ORM2020 dbContexte, string suiteCaracteres)
        {
            Console.WriteLine("\r\nRequête 1\r\n");
            var searchByChar = dbContexte.StagiaireOffreFormation.Where(x => x.Stagiaire.NomPersonne.Contains(suiteCaracteres)).Select(res => new 
                               { 
                                    Matricule = res.Stagiaire.MatriculeStagiaire, 
                                    Nom = res.Stagiaire.NomPersonne, 
                                    Prenom = res.Stagiaire.PrenomPersonne, 
                                    DateNaissance = res.Stagiaire.DateNaissanceStagiaire 
                                }).OrderBy(x => x.Nom);
            ObjectDumper.Write(searchByChar);

        }
        /// <summary>
        /// Recherche entreprise
        /// à partir du SIRET
        /// </summary>
        /// <param name="siret"></param>
        public static void Req_02_RechercheEntrepriseBySiret(ORM2020 dbContexte, string siret)
        {
            Console.WriteLine("\r\nRequête 2\r\n");
            var searchEntr = dbContexte.Entreprise.Where(x => x.NumeroSiret == siret);
            ObjectDumper.Write(searchEntr);
           
        }
        /// <summary>
        /// Liste des stagiaires par offre de formation
        /// </summary>
        /// <param name="idOffreFormation"></param>
        /// <param name="idEtablissement"></param>
        static public void Req_03_ListeStagiaires(ORM2020 dbContexte, int idOffreFormation, string idEtablissement)
        {
            Console.WriteLine("\r\nRequête 3\r\n");
            var searchStaEta = dbContexte.StagiaireOffreFormation.Where(x => x.IdOffreFormation == idOffreFormation && x.IdEtablissement == idEtablissement).Select(res => new
            {
                Matricule = res.Stagiaire.MatriculeStagiaire,
                Civilite = res.Stagiaire.CivilitePersonne,
                Nom = res.Stagiaire.NomPersonne,
                Prenom = res.Stagiaire.PrenomPersonne,
                Designation = res.OffreFormation.ProduitOffre.DesignationProduitFormation
            });
            ObjectDumper.Write(searchStaEta);
        }

        ///// <summary>
        ///// Volumes de bénéficiaires pour un établissement et une année
        ///// </summary>
        ///// <param name="annee"></param>
        ///// <param name="idEtablissement"></param>
        public static void Req_04_VolumesParAnneeEtablissement(ORM2020 dbContexte, int annee, string idEtablissement)
        {
            Console.WriteLine("\r\nRequête 4\r\n");
            var nbStaAnn = dbContexte.StagiaireOffreFormation.Where(x => x.IdEtablissement == idEtablissement && x.DateEntreeStagiaire.Year == annee).Count();
            Console.WriteLine("Il y a eu {0} stagiares pour l'année {1}",nbStaAnn,annee);
        }
        /// <summary>
        /// Liste des stagiaires démissionnaires
        /// </summary>
        /// <param name="annee"></param>
        /// <param name="idEtablissement"></param>
        public static void Req_05_StagiairesDemissionnairesParAnneeEtablissement(ORM2020 dbContexte, int annee, string idEtablissement)
        {
            Console.WriteLine("\r\nRequête 5\r\n");
            var staDem = dbContexte.StagiaireOffreFormation.Where(x => x.DateSortieStagiaire < x.OffreFormation.DateFinOffreFormation && x.DateSortieStagiaire != null && x.OffreFormation.DateDebutOffreFormation.Year == annee && x.IdEtablissement == idEtablissement).Select(res => new
            {
                MatriculeStagiaire = res.Stagiaire.MatriculeStagiaire,
                Nom = res.Stagiaire.NomPersonne,
                Prenom = res.Stagiaire.PrenomPersonne
            });
            ObjectDumper.Write(staDem);

        }
        /// <summary>
        /// Taux de départ anticipé / Année & ETablissement
        /// </summary>
        /// <param name="annee"></param>
        /// <param name="idEtablissement"></param>
        public static void Req_06_TauxDepartAnticipeParAnneeEtablissement(ORM2020 dbContexte, int annee, string idEtablissement)
        {
            Console.WriteLine("\r\nRequête 6\r\n");
            var staDem = dbContexte.StagiaireOffreFormation.Where(x => x.DateSortieStagiaire < x.OffreFormation.DateFinOffreFormation && x.DateSortieStagiaire != null && x.OffreFormation.DateDebutOffreFormation.Year == annee && x.IdEtablissement == idEtablissement).Count();
            var nbStaAnn = dbContexte.StagiaireOffreFormation.Where(x => x.IdEtablissement == idEtablissement && x.DateEntreeStagiaire.Year == annee).Count();
            double ratio = 100.0 * staDem / nbStaAnn;
            Console.WriteLine("Le taux de départ anticipé est de {0}",Math.Round(ratio,2));
        }
        /// <summary>
        /// Liste des personnes responsables juridiques ou tuteurs pour une entreprise connue
        /// </summary>
        /// <param name="siret"></param>
        public static void Req_07_ListeTiersEntrepriseBySiret(ORM2020 dbContexte, string siret)
        {
            Console.WriteLine("\r\nRequête 7 \r\n");
            var pee = dbContexte.PeriodePee.Where(x => x.IdPeeNavigation.EntreprisePee.NumeroSiret == siret);
            var peeRes = pee.Select(res => new
            {
                IdReponsable = res.IdPeeNavigation.IdResponsableJuridique,
                Nom = res.IdPeeNavigation.ResponsableJuridique.NomPersonne + " " + res.IdPeeNavigation.ResponsableJuridique.PrenomPersonne
            }).Distinct().ToList();
            var peeTut = pee.Select(res => new
            {
                IdTuteur = res.IdPeeNavigation.IdTuteur,
                Nom = res.IdPeeNavigation.Tuteur.NomPersonne + " " + res.IdPeeNavigation.Tuteur.PrenomPersonne
            }).Distinct().ToList();

            ObjectDumper.Write(peeRes);
            ObjectDumper.Write(peeTut);
        }

    }
}

