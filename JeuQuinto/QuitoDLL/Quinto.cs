using System;
using DictionnaireDLL;
using System.Configuration;

namespace QuintoDLL
{
    public class Quinto
    {
        #region Private
        private MotDictionnaire _wordSource;
        private MotDictionnaire _wordToFind;
        private int _nbRound;
        private int _nbError;
        private int _nbTry;
        private int _score;
        private Dictionnaire _wordList;
        #endregion

        #region Public
        public MotDictionnaire WordSource { get => _wordSource; set => _wordSource = value; }
        public MotDictionnaire WordToFind { get => _wordToFind; set => _wordToFind = new MotDictionnaire(); }
        public int NbRound { get => _nbRound; set => _nbRound = value; }
        public int NbError { get => _nbError; set => _nbError = value; }
        public int NbTry { get => _nbTry; set => _nbTry = value; }
        public int Score { get => _score; set => _score = value; }
        public Dictionnaire WordList 
        { 
            get => _wordList;
            set => _wordList = new Dictionnaire();
        }
        

        #endregion
        #region Method
        private int CalculScore(int pointBySecond, int nbOfTick, int pointByError, int nbError)
        {
            return (pointBySecond * nbOfTick) + (pointByError * nbError);
        }
        
        #endregion
    }
}
