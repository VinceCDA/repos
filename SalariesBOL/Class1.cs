using System;

namespace SalariesBOL
{

    public class Salarie
    {
        public Salarie()
        {

        }

        private string _matricule;
        public string Matricule
        {
            get => _matricule; set
            {
                if (controleMatricule(value))
                {
                    _matricule = value;
                }
                else
                {
                    throw new ApplicationException($"la valeur {value} n'est pas correcte");
                }
               
            }
        }
        private string _nom;
        public string Nom
        {
            get => _nom; set
            {
                if (controleNom(value))
                {
                    _nom = value;
                }
                else
                {
                    throw new ApplicationException($"la valeur {value} n'est pas correcte");

                }
            }
        }

        private string _prenom;
        public string Prenom
        {
            get => _prenom; set
            {
                if (controleNom(value))
                {
                    _prenom = value;
                }
                else
                {
                    throw new ApplicationException($"la valeur {value} n'est pas correcte");
                }
            }
        }
        private int _salaireBrut;
        public int SalaireBrut { get => _salaireBrut; set => _salaireBrut = value; }
        private double _tauxCs;
        public double TauxCs
        {
            get => _tauxCs; set
            {
                if (controleTauxCs(value))
                {
                    _tauxCs = value;
                }
                else
                {
                    throw new ApplicationException($"la valeur {value} n'est pas correcte");
                }
            }
        }


        //public double SalaireNet { get => calculSalaireNet(); }
        private double _salaireNet;

        public double SalaireNet { get => calculSalaireNet(); set => _salaireNet = value; }
        public DateTime DateNaissance
        {
            get => _dateNaissance; set
            {
                if (controleDateNaissance(value))
                {
                    _dateNaissance = value;
                }
                else
                {
                    throw new ApplicationException($"la valeur {value} n'est pas correcte");
                }
            }
        }

        

        private DateTime _dateNaissance=new DateTime(1962,12, 11);

        public class Com : Salarie
        {

            public Com() : base()
            {

            }

            int _chiffreAffaire;
            double _commission;

            public int ChiffreAffaire { get => _chiffreAffaire; set => _chiffreAffaire = value; }
            public double Commission { get => _commission; set => _commission = value; }

            public override double calculSalaireNet()
            {
                return base.calculSalaireNet() + ChiffreAffaire * Commission;
            }


        }


        public virtual double calculSalaireNet()
        {

            return SalaireBrut - SalaireBrut * TauxCs;


        }
        public bool controleMatricule()
        {
            
            if (Matricule.Length == 7)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (Char.IsDigit(Matricule[i]) == false)
                    {
                        return false;
                    }
                    
                }
                for (int i = 2; i < 5; i++)
                {
                    if (Char.IsLetter(Matricule[i]) == false)
                    {
                        return false;
                    }
                }
                for (int i = 5; i < 7; i++)
                {
                    if (Char.IsDigit(Matricule[i]) == false)
                    {
                        return false;
                    }
                }
                return true;

            }
            return false;

        }
        public static bool controleMatricule(string matricule)
        {

            if (matricule.Length != 7)
            {
                return false;
            }
                for (int i = 0; i < 2; i++)
                {
                    if (Char.IsDigit(matricule[i]) == false)
                    {
                        return false;
                    }

                }
                for (int i = 2; i < 5; i++)
                {
                    if (Char.IsLetter(matricule[i]) == false)
                    {
                        return false;
                    }
                }
                for (int i = 5; i < 7; i++)
                {
                    if (Char.IsDigit(matricule[i]) == false)
                    {
                        return false;
                    }
                }
                return true;

        }
        public static bool controleNom(string nom)
        {
            if (nom.Length < 4 || nom.Length > 31)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < nom.Length; i++)
                {
                    if (Char.IsDigit(nom[i]) == true)
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }
        public static bool controleTauxCs(double tauxcs)
        {
            if (tauxcs >= 0 && tauxcs <= 0.6)
            {
                return true;
            }
            return false;
        }
        public static bool controleDateNaissance(DateTime naissance)
        {
            DateTime today = DateTime.Today;
            DateTime d1 = new DateTime(1900, 01, 01);
            DateTime d2 = today.AddYears(-15);
            if (DateTime.Compare(naissance, d1) == 1 && DateTime.Compare(naissance, d2) < 0)
            {
                return true;
            }
            return false;
        }
        public static bool Equals(string mat1, string mat2)
        {
            if (mat1.GetHashCode() == mat2.GetHashCode())
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            Console.WriteLine("{0};{1};{2};{3};{4};{5}",Matricule, Nom, Prenom, SalaireBrut, TauxCs, DateNaissance);

            return "";
        }
    }
 
}
    


