using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp6
{
    [Flags]
    public enum Autorisations : byte
    {
        Lecture = 1, // 0001
        Ecriture = 2, // 0010
        Proprietaire = 4 // 0100      
    }
    public class Utilisateur
    {
        public string Profil { get; set; }
        public Autorisations AuthoriserEn { get; set; }

    }
    class Program
    {
        private static HashSet<Utilisateur> utilisateurs;
        static void Main(string[] args)
        {

            // DefinirAutorisations();
            // AfficherAutorisations();
            // TesterOperateurUnaire();
            AfficherFichier();
            string chaine = "Bonjour les Concepteurs Développeurs d'Application. Un petit jeu avec les opérations bit à bit";
            int cle = 1962;
            string chaineEncodee = EncoderDecoderChaineV2(chaine, cle);
            string chaineDecodee = EncoderDecoderChaineV2(chaineEncodee, cle);
            Console.ReadLine();
        }

        private static void AfficherAutorisations()
        {
            foreach (var utilisateur in utilisateurs)
            {
                Console.WriteLine("Utilisateur {0}", utilisateur.Profil);
                Console.WriteLine(((utilisateur.AuthoriserEn & Autorisations.Lecture) == Autorisations.Lecture)
                    ? "Lecture Autorisée" : "Pas lecture");
                Console.WriteLine(((utilisateur.AuthoriserEn & Autorisations.Ecriture) == Autorisations.Ecriture)
                    ? "Ecriture Autorisée" : "Pas écriture");
                Console.WriteLine(((utilisateur.AuthoriserEn & Autorisations.Proprietaire) == Autorisations.Proprietaire)
                    ? "Propriétaire" : "Pas propriétaire");

            }
            Console.ReadLine();
        }
        static void DefinirAutorisations()
        {
            utilisateurs = new HashSet<Utilisateur>();
            utilisateurs.Add(new Utilisateur
            {
                Profil = "Bost",
                AuthoriserEn = Autorisations.Ecriture | Autorisations.Lecture
            });
            utilisateurs.Add(new Utilisateur
            {
                Profil = "Eric",
                AuthoriserEn = Autorisations.Lecture
            });
            utilisateurs.Add(new Utilisateur
            {
                Profil = "Jacques",
                AuthoriserEn = Autorisations.Proprietaire
            });

        }

        static void AfficherFichier()
        {

            Console.WriteLine("Valeurs de l'énumération FileAttributes");

            foreach (int item in Enum.GetValues(typeof(System.IO.FileAttributes)))
            {
                Console.WriteLine($"Nom attribut : {Enum.GetName(typeof(System.IO.FileAttributes), item)} " +
                    $"Valeur Binaire : {Convert.ToString(item, toBase: 2)}" +
                    $" Valeur Héxa : {Convert.ToString(item, 16)} " +
                    $"valeur décimale {Convert.ToString(item, 10)}");

            }

            System.IO.DirectoryInfo repertoire = new System.IO.DirectoryInfo(@"C:\Data");
            System.IO.FileInfo[] fichiers = repertoire.GetFiles("*.*");
            System.IO.FileAttributes attributs = fichiers[0].Attributes;
            Console.WriteLine("");
            Console.WriteLine($"Valeur attributs du fichier = Valeur Binaire : " +
                $" {Convert.ToString((int)attributs, toBase: 2)}" +
                    $" Valeur décimale {Convert.ToString((int)attributs, 10)}");
            Console.WriteLine("");

            Console.WriteLine($"Lecture seule ? : attributs & FileAttributes.ReadOnly :" +
                $" {Convert.ToString((int)(attributs & FileAttributes.ReadOnly), toBase: 2)}" +
                $" {(attributs & FileAttributes.ReadOnly) == FileAttributes.ReadOnly}");
            Console.WriteLine("");
            Console.WriteLine($"Caché ? : attributs & FileAttributes.Hidden : " +
                $"{Convert.ToString((int)(attributs & FileAttributes.Hidden), toBase: 2)}" +
                $" {(attributs & FileAttributes.Hidden) == FileAttributes.Hidden}");

        }
        static void TesterOperateurUnaire()
        {
            Console.WriteLine(1 & 1);
            Console.WriteLine($"Binaire:{Convert.ToString(1, toBase: 2)}");
            Console.WriteLine(2 & 3);
            Console.WriteLine($"Binaire:{Convert.ToString(3, toBase: 2)}");
            Console.WriteLine($"Binaire:{Convert.ToString(2 & 3, toBase: 2)}");
            Console.WriteLine($"Binaire:{Convert.ToString(2 & 4, toBase: 2)}");
            Console.WriteLine(1 | 1);
            Console.ReadLine();
        }

        static string EncoderDecoderChaine(string chaine, int cle)
        {
            string sEncDec = null;
            foreach (char car in chaine)
            {
                sEncDec += Convert.ToChar(car ^ cle);
            }
            return sEncDec;
        }
        static string EncoderDecoderChaineV2(string chaine, int cle)
        {
            return new String(chaine.Select(car => Convert.ToChar(car ^ cle)).ToArray());
        }

    }
}

