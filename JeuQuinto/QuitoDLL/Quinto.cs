using System;
using DictionnaireDLL;
using System.Configuration;
using System.Text;
using System.Globalization;
using System.Linq;

namespace QuintoDLL
{
    public class Quinto
    {
        #region Private
        
        private Dictionnaire _wordList;
        private MotDictionnaire _wordToFind;
        private char[] _wordToFindArray;
        private char[] _wordToFindHidden;
        private int _nbRound;
        private int _nbRoundMax;
        private int _nbError;
        private int _nbErrorMax;
        private int _nbPointByError;
        private int _nbPointByTick;
        private int _timer;
        private int _score;
        
        #endregion

        #region Public
        public Dictionnaire WordList
        {
            get => _wordList;
            set => _wordList = value;
        }
        public MotDictionnaire WordToFind
        {
            get => _wordToFind;
            set => _wordToFind = value;
        }
        public char[] WordToFindArray 
        {
            get => _wordToFindArray; 
            set => _wordToFindArray = value; 
        }
        public char[] WordToFindHidden 
        { 
            get => _wordToFindHidden; 
            set => _wordToFindHidden = value; 
        }

        public int NbRound
        {
            get => _nbRound;
            set {
                _nbRound = value;
                OnNbRound(EventArgs.Empty); 
            }
            
        }
        public int NbRoundMax 
        {
            get => _nbRoundMax;
            set => _nbRoundMax = value; 
        }
        public int NbError 
        { 
            get => _nbError; 
            set => _nbError = value; 
        }
        public int NbErrorMax 
        { 
            get => _nbErrorMax; 
            set => _nbErrorMax = value; 
        }
        public int NbPointByError 
        { 
            get => _nbPointByError; 
            set => _nbPointByError = value; 
        }
        public int NbPointByTick 
        { 
            get => _nbPointByTick; 
            set => _nbPointByTick = value; 
        }
        public int Timer 
        { 
            get => _timer; 
            set => _timer = value; 
        }
        public int Score 
        { 
            get => _score; 
            set => _score = value; 
        }
        

        #endregion
        #region Constructeur
        public Quinto(string pathDict)
        {
            WordList = new Dictionnaire(pathDict);
            NewWord();
            NbRound = 1;
            NbError = 0;
            Score = 0;
            Timer = 0;
            NewRound += Meth;
            
        }
        #endregion
        private event EventHandler NewRound;
        protected virtual void OnNbRound(EventArgs e)
        {
            if (NewRound != null)
            {
                NewRound(this, EventArgs.Empty);
            }
            
        }
        private void Meth(object sender, EventArgs e)
        {
            NewWord();
        }

        #region Method
        /// <summary>
        /// Calcul du score
        /// </summary>
        /// <returns></returns>
        public int CalculScore()
        {
            return (NbPointByTick * Timer) + (NbError * NbPointByError);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private MotDictionnaire WordControl(MotDictionnaire word)
        {
            word = WordList.ExtraireMot();
            //word.Mot = CleaningWord(word.Mot);
            if ((word.Mot.Length) < 5 || (word.Mot.Length) > 25 || word.Mot.Contains(" ") || word.Mot.Contains("."))
            {
                word = WordList.ExtraireMot();
            }
            word.Mot = Norma(word.Mot);
            word.Mot = word.Mot.ToUpper();
            return word;

        }
        /// <summary>
        /// Normalisation du mot
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string Norma(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        /// <summary>
        /// Cache le mot a trouver
        /// </summary>
        /// <param name="vs"></param>
        /// <returns></returns>
        private char[] HideChar(char[] vs)
        {
            char[] output = new char[vs.Length];
            for (int i = 0; i < vs.Length; i++)
            {
                output[i] = '_';
            }
            return output;
        }
        /// <summary>
        /// Genration d'un nouveau mot
        /// </summary>
        private void NewWord()
        {
            WordToFind = WordControl(WordToFind);
            WordToFindArray = WordToFind.Mot.ToCharArray();
            WordToFindHidden = HideChar(WordToFindArray);
        }
        /// <summary>
        /// Verifie si le char est present.
        /// </summary>
        /// <param name="hidden"></param>
        /// <param name="result"></param>
        /// <param name="check"></param>
        /// <returns></returns>
        public char[] CheckChar(char[] hidden, char[] result, char check)
        {

            for (int i = 0; i < hidden.Length; i++)
            {
                if (result[i] == check)
                {
                    hidden[i] = check;
                }

            } 
           
            return hidden;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hidden"></param>
        /// <returns></returns>
        public bool CheckWinCondtion(char[] hidden)
        {
            
            int check = 0;
            for (int i = 0; i < hidden.Length; i++)
            {
                if (!(hidden[i] == '_'))
                {
                    check += 1;
                }
            }
            if (check == hidden.Length)
            {
                return true;
            }
            return false;

        }
        /// <summary>
        /// Check si le mot est decouvert.
        /// </summary>
        /// <param name="hidden"></param>
        /// <returns></returns>
        public bool CheckWinCond(char[] hidden)
        {
            return hidden.Contains('_');
  
        }
        #endregion
        


    }
}
