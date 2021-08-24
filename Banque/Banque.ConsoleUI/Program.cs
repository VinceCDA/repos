using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banque.BOL;
using Banque.DAL;

namespace Banque.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DB.DbConnectionString = Properties.Settings.Default.BanqueConnectionString;
            ListerComptes("23456754");
        }

        private static void ListerComptes(string codeClient)
        {
            Client client = ClientDAC.Instance.GetClientById(codeClient);
            foreach (Compte compte in CompteDAC.Instance.GetComptesByCodeClient(client))
            {
                Console.WriteLine($"N° compte : {compte.NumeroCompte}");
            }
            Console.ReadLine();
        }
    }
}
