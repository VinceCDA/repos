using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AFPA.BOL;

namespace AFPA.DAL
{
    
    public partial class AFPA_ORMEntities 
    {
        public IQueryable<Stagiaire> Stagiaires
        {
            get { return Personne.OfType<Stagiaire>() ;}
        }
        public IQueryable<CollaborateurAfpa> CollaborateursAfpa
        {
            get { return Personne.OfType<CollaborateurAfpa>(); }
        }
        public IQueryable<ProduitFormationQualifiant> ProduitsQualifiant
        {
            get { return this.ProduitDeFormation.OfType<ProduitFormationQualifiant>(); }
        }
    }
}
