using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.BOL
{
    public enum StatutAuthentification
    {
        IDInvalide = -101,
        MotPasseInvalide = -102,
        CompteBloqué = -103,
        ConnexionOK = 0
    }
}
