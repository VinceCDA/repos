using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Poo3
{
    [Serializable()]
    public class Salaries : List<Salarie>
    {
        public Salaries() : base()
        {

        }

        public new void Add(Salarie salarie)
        {
            try
            {
                bool trouve = false;
                foreach (Salarie element in this)
                {

                    if (element.Equals(salarie))
                    {
                        trouve = true;
                        throw new SalarieException("01", "Le salarie existe deja.");
                    }

                }
                if (!trouve)
                {
                    base.Add(salarie);
                    
                }

            }
            catch (SalarieException)
            {

                
                throw;
            }
            

            
           
        }
        public Salarie GetSalarie(string matricule)
        {
            
            foreach (Salarie element in this)
            {

                if (element.Matricule.Equals(matricule))
                {


                    
                    return element;

                }



            }
            return null;
            



        }
        public void RemoveSalarie(string matricule)
        {
            Remove(GetSalarie(matricule));




        }

        public void SaveText(string path)
        {
            FileStream fs = new FileStream($"{path}" + @"\Salaries.csv",FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(fs);

            foreach (Salarie item in this)
            {
                string line = item.ToString();
                sw.WriteLine(line);
            }
            sw.Close();
            fs.Close();
            
        }
        public void LoadText()
        {
            FileStream fs = new FileStream(@"c:\Salaries.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            while (line != null)
            {
                
                string[] lineSub = line.Split(';');
                Salarie salarie = new Salarie(lineSub[1], lineSub[2], lineSub[0]);
                salarie.SalaireBrut = Decimal.Parse(lineSub[3]);
                salarie.TauxCS = Decimal.Parse(lineSub[4]);
                salarie.DateNaissance = DateTime.Parse(lineSub[5]);
                this.Add(salarie);
                line = sr.ReadLine();
            }
            
            sr.Close();
            fs.Close();

        }
        public void SaveXml()
        {
            FileStream fs = new FileStream(@"c:\Salaries.xml", FileMode.CreateNew);
            XmlTextWriter xmlW = new XmlTextWriter(fs, Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(this.GetType());
            xmlS.Serialize(xmlW, this);
            fs.Close();
        }
        public void LoadXml()
        {
            FileStream fs = new FileStream(@"c:\Salaries.xml", FileMode.Open);
            XmlTextReader xmlR = new XmlTextReader(fs);
            XmlSerializer xmlS = new XmlSerializer(this.GetType());
            base.AddRange(xmlS.Deserialize(xmlR) as Salaries);
            fs.Close();
        }



        

    }
    public class SalaireModifieEventArgs : EventArgs
    {
        decimal _ancienSalaireArg;
        decimal _salaireBrutArg;
        
        public SalaireModifieEventArgs(decimal anciensalaire, decimal salairebrut)
        {
            AncienSalaireArg = anciensalaire;
            SalaireBrutArg = salairebrut;
        }

        public decimal AncienSalaireArg { get => _ancienSalaireArg; set => _ancienSalaireArg = value; }
        public decimal SalaireBrutArg { get => _salaireBrutArg; set => _salaireBrutArg = value; }
    }
    
}
