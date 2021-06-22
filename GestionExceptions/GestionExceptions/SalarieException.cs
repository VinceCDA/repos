using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ComposantSalaries
{
    /// <summary>
    /// Exception spécifique pour Salarie
    /// </summary>
    [Serializable]
    public class SalarieException : ApplicationException, ISerializable
    {
        private string _idMessage = string.Empty;
        /// <summary>
        /// Identifiant du message
        /// </summary>
        public string IdMessage
        {
            get { return _idMessage; }
            set { _idMessage = value; }
        }
        /// <summary>
        /// Exception Constructeur de base
        /// </summary>
        public SalarieException()
            : base()
        { }
        /// <summary>
        /// Exception Constructeur / message texte
        /// </summary>
        /// <param name="message"></param>
        public SalarieException(string IdMessage,string message)
            : base(message)
        { _idMessage = IdMessage; }
        /// <summary>
        /// Exception Constructeur / message/ inner
        /// </summary>
        /// <param name="message">Message d'origine de l'exception</param>
        /// <param name="inner">Inner</param>
        public SalarieException(string IdMessage,string message, Exception inner)
            : base(message, inner)
        { _idMessage = IdMessage; }

        /// <summary>
        /// Constructeur nécessaire pour la sérialisation des exceptions
        /// notamment dans les services Web
        ///
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected SalarieException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
     
    }
}
