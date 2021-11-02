using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AFPA.BOL
{
    public enum EntityPOCOState
    {

        //
        // Résumé :
        //     L'entité est suivie par le contexte et existe dans la base de données, et
        //     les valeurs de propriété n'ont pas changé par rapport aux valeurs dans la
        //     base de données.
        Unchanged = 2,
        //
        // Résumé :
        //     L'entité est suivie par le contexte, mais n'existe pas encore dans la base
        //     de données.
        Added = 4,
        //
        // Résumé :
        //     L'entité est suivie par le contexte et existe dans la base de données, mais
        //     est marquée pour suppression de la base de données lors du prochain appel
        //     de SaveChanges.
        Deleted = 8,
        //
        // Résumé :
        //     L'entité est suivie par le contexte et existe dans la base de données, et
        //     certaines de ses valeurs de propriété ont été modifiées.
        Modified = 16,
    }
    public interface IEntityPOCOState
    {
       
        EntityPOCOState Etat
        {
            get;
            set;
        }
    }
  
    
}
