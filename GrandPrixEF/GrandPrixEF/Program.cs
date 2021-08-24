using System;
using System.Linq;
using GrandPrixEF.Models;
using Microsoft.EntityFrameworkCore;

namespace GrandPrixEF
{
    class Program
    {
        static readonly GPF1DBContext gPF1DBContext = new();
        static void Main()
        {
            //R01_ListePilotes("a");
            //R02_ListePilotes_Paginee("a", 2, 3);
            //R03_ListeGP();
            //R04_ClassementPilotes();
            R05_ClassementEcuries();
            //R06_PilotesToujoursQualifies();
        }
        private static void R01_ListePilotes(string recherche)
        {

           
            Console.WriteLine($"Liste des pilotes dont nom contient ({recherche})");
            
            Console.WriteLine("-----------------------------");
            using (GPF1DBContext dBContext = new GPF1DBContext())
            {
                var piltoteSearch = dBContext.Pilote.Where(x => x.NomPilote.Contains(recherche)).
                    Select(res => new { Code = res.CodePilote, Nom = res.NomPilote, Prenom = res.PrenomPilote, Ecurie = res.CodeEcurieNavigation.NomEcurie }).
                    OrderBy(ord => ord.Nom).ToList();
                foreach (var item in piltoteSearch)
                {
                    Console.WriteLine("Code: {0} Nom: {1} {2} Ecurie : {3}", item.Code, item.Nom,item.Prenom,item.Ecurie);
                }
            }
            Console.ReadLine();
        }
        private static void R02_ListePilotes_Paginee(string recherche, int page, int taillePage)
        {
           
            Console.WriteLine($"Liste des pilotes nom contient ({recherche}) Page ({page}) taille page ({taillePage})");
            using (GPF1DBContext dBContext = new GPF1DBContext())
            {
                var piltoteSearch = dBContext.Pilote.Where(x => x.NomPilote.Contains(recherche)).Select
                    (res => new { Code = res.CodePilote, Nom = res.NomPilote, Prenom = res.PrenomPilote, Ecurie = res.CodeEcurieNavigation.NomEcurie }).
                    OrderBy(ord => ord.Nom).Skip((page - 1) * taillePage).Take(taillePage).ToList();
                foreach (var item in piltoteSearch)
                {
                    Console.WriteLine("Code: {0} Nom: {1} {2} Ecurie : {3}", item.Code, item.Nom, item.Prenom, item.Ecurie);
                }
            }
            
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }
        private static void R03_ListeGP()
        {
            
            Console.WriteLine("Liste des GP par Dates");
            using (GPF1DBContext dBContext = new GPF1DBContext())
            {
                var lstGp = dBContext.PlanificationGp.Select(res => new
                {
                    CodeGp = res.CodeGp,
                    NomGp = res.CodeGpNavigation.NomGrandPrix,
                    NomC = res.CodeCircuitNavigation.NomCircuit,
                    Date = res.DateGp,
                    Distance = (res.NombreTours * res.CodeCircuitNavigation.LongueurPiste) / 1000.0
                }).OrderBy(x => x.Date).ToList();
                foreach (var item in lstGp)
                {
                    Console.WriteLine("CodeGP : {0} NomGP : {1} Circuit : {2} Date : {3} Distance : {4}Km", item.CodeGp, item.NomGp, item.NomC, item.Date, item.Distance);
                }
            }
            Console.WriteLine("-----------------------------");
            Console.ReadLine();

        }
        private static void R04_ClassementPilotes()
        {
           
            Console.WriteLine("Classement des pilotes");
            using (GPF1DBContext dBContext = new GPF1DBContext())
            {
                var classPil = dBContext.Pilote.Select(res => new 
                { 
                    Code = res.CodePilote, 
                    Nom = res.NomPilote, 
                    Prenom = res.PrenomPilote, 
                    Points = res.ResultatCourse.Sum(x => x.NombrePointsMarques) 
                }).OrderByDescending(x => x.Points).ToList();
                foreach (var item in classPil)
                {
                    Console.WriteLine("Code : {0} Nom : {1} {2} Points : {3}", item.Code, item.Nom, item.Prenom, item.Points);
                }
            }
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }
        private static void R05_ClassementEcuries()
        {
            Console.WriteLine("Classement des écuries");
            using (GPF1DBContext dBContext = new GPF1DBContext())
            {
                var classEcu = dBContext.Pilote.
                    Select(res => new
                    {
                        Points = res.ResultatCourse.Sum(x => x.NombrePointsMarques),
                        EcurieNom = res.CodeEcurieNavigation.NomEcurie,
                        CodeEcurie = res.CodeEcurie
                    }).ToList().GroupBy(x => new { x.EcurieNom, x.CodeEcurie}).Select(e=>new{e.Key.CodeEcurie,e.Key.EcurieNom,points=e.Sum(s=>s.Points)}).OrderByDescending(x => x.points);
                foreach (var ecu in classEcu)
                {
                    Console.WriteLine("Ecurie : {0} Nom : {1} Points : {2}", ecu.CodeEcurie,ecu.EcurieNom,ecu.points);
                    
                }
                var test = from pil in dBContext.Pilote
                           join ecu in dBContext.Ecurie on pil.CodeEcurie equals ecu.CodeEcurie
                           join res in dBContext.ResultatCourse on pil.CodePilote equals res.CodePilote
                           group pil by ecu.CodeEcurie into g
                           select new { er = g.Key };
                           //select new { Code = ecu.CodeEcurie, Ecu = ecu.NomEcurie, Points = res.NombrePointsMarques };
                           
                           //group pil.CodePilote by pil.CodeEcurie into g
                           //select g;
                           
                

            }

            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }
        private static void R06_PilotesToujoursQualifies()
        {
            Console.WriteLine("Pilotes toujours qualifiés et sans abandon");
            using (GPF1DBContext dBContext = new GPF1DBContext())
            {
                var pil = dBContext.Pilote.Where(x => x.ResultatCourse.All(y => y.Abandon == false && y.Qualifie == true)).Select(res => new
                {
                    Code = res.CodePilote,
                    Nom = res.NomPilote+" "+res.PrenomPilote
                }).ToList();
                foreach (var item in pil)
                {
                    Console.WriteLine("Code : {0} Nom : {1}", item.Code,item.Nom);
                }
            }
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }
    }
}

