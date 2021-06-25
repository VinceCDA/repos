using System;
using DictionnaireDLL;
using System.Configuration;

namespace QuintoDLL
{
    public class Quinto
    {
        #region Private
        private MotDictionnaire _wordToFindArray;
        private MotDictionnaire _wordToFind;
        private int _nbRound;
        private int _nbError;
        private int _nbTry;
        private int _score;
        private Dictionnaire _wordList;
        #endregion

        #region Public
        public MotDictionnaire WordSource { get => _wordToFindArray; set => _wordToFindArray = value; }
        public MotDictionnaire WordToFind
        {
            get => _wordToFind;
            set => _wordToFind = value; 
        }
        public int NbRound { get => _nbRound; set => _nbRound = value; }
        public int NbError { get => _nbError; set => _nbError = value; }
        public int NbTry { get => _nbTry; set => _nbTry = value; }
        public int Score { get => _score; set => _score = value; }
        public Dictionnaire WordList 
        { 
            get => _wordList = new Dictionnaire("C:\\Users\\CDA\\source\\repos\\JeuQuinto\\JeuWinForms\\AppData\\FR-fr.xml");
            set => _wordList = value;
        }
        

        #endregion
        #region Method
        private int CalculScore(int pointBySecond, int nbOfTick, int pointByError, int nbError)
        {
            return (pointBySecond * nbOfTick) + (pointByError * nbError);
        }
        public MotDictionnaire WordControl(Quinto quinto)
        {
            quinto.WordToFind = quinto.WordList.ExtraireMot();
            if ((quinto.WordToFind.Mot.Length) < 3 || (quinto.WordToFind.Mot.Length) > 25)
            {
                quinto.WordToFind = quinto.WordList.ExtraireMot();
            }
            
            quinto.WordToFind.Mot = quinto.WordToFind.Mot.ToUpper();
            return quinto.WordToFind;
            


        }
        
        #endregion
    }
}
