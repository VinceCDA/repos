using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace JeuWinForms

{
    [Serializable()]
    public class HighScore
    {
        private string _userName;
        private int _score;

        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }
        public int Score
        {
            get => _score;
            set => _score = value;
        }
        public void LoadScore(List<HighScore> highScores)
        {
            FileStream fileStream;
            XmlTextReader xmlTR;
            XmlSerializer xmlS;
            fileStream = new FileStream(Properties.Settings.Default.RepertoireDictionnaires + "\\highscore.xml", FileMode.Open);
            xmlTR = new XmlTextReader(fileStream);
            xmlS = new XmlSerializer(highScores.GetType());
            highScores.AddRange((IEnumerable<HighScore>)(xmlS.Deserialize(xmlTR)));
            fileStream.Close();
            //PersistanceServiceXML.SauvegardeXML.Load<HighScrores>(Properties.Settings.Default.RepertoireDictionnaires);
        }
        public void SaveScore(List<HighScore> highScores)
        {
            FileStream fileStream;
            XmlTextWriter xmlTW;
            XmlSerializer xmlS;
            fileStream = new FileStream("C:\\Users\\CDA\\source\\repos\\JeuQuinto\\JeuWinForms\\AppData\\highscore.xml", FileMode.OpenOrCreate);
            xmlTW = new XmlTextWriter(fileStream, Encoding.UTF8);
            xmlS = new XmlSerializer(highScores.GetType());
            xmlS.Serialize(xmlTW, highScores);
            fileStream.Close();
            //PersistanceServiceXML.SauvegardeXML.Load<HighScrores>(Properties.Settings.Default.RepertoireDictionnaires);
        }

    }



}
