using System;
using DictionnaireDLL;
using System.Configuration;
using System.Text;
using System.Globalization;



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
            get => _wordList = new Dictionnaire("C:\\Users\\CDA\\source\\repos\\JeuQuinto\\JeuWinForms\\AppData\\FR-fr.xml");
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
            set => _nbRound = value; 
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
        public Quinto()
        {
            //gameSession.NbRoundMax = Properties.Settings.Default.NombreManches;
            //gameSession.NbErrorMax = Properties.Settings.Default.NombreErreurs;
            //gameSession.NbPointByError = Properties.Settings.Default.NombrePointsErreur;
            //gameSession.NbPointByTick = Properties.Settings.Default.NombrePointsParSeconde;
            WordToFind = WordControl(WordToFind);
            WordToFindArray = WordToFind.Mot.ToCharArray();
            WordToFindHidden = HideChar(WordToFindArray);
            NbRound = 1;
            NbError = 0;
            Score = 0;
            Timer = 0;
            
        }
        #endregion
        #region Method

        public int CalculScore()
        {
            return (NbPointByTick * Timer) + (NbError * NbPointByError);
        }

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

        private char[] HideChar(char[] vs)
        {
            char[] output = new char[vs.Length];
            for (int i = 0; i < vs.Length; i++)
            {
                output[i] = '_';
            }
            return output;
        }
        public void NewWord()
        {
            WordToFind = WordControl(WordToFind);
            WordToFindArray = WordToFind.Mot.ToCharArray();
            WordToFindHidden = HideChar(WordToFindArray);
        }
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
        #endregion


    }
}
