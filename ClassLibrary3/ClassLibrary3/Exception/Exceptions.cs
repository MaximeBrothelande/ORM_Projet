using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_ORM.Exception
{
       /// <summary>
       /// Exceptions liées aux connexions
       /// </summary>
    public class ORMExceptionsConnection : Exception
    {
        /// <summary>
        /// Nouvelle instance de la classe
        /// </summary>
        public ORMExceptionsConnection()
        {
        }

        /// <summary>
        /// Nouvelle instance de la classe
        /// </summary>
        /// <param name="message">Message d'erreur</param>
        public ORMExceptionsConnection(string message)
        {
        }

        /// <summary>
        /// Nouvelle instance de la classe
        /// </summary>
        /// <param name="message">Message d'erreur</param>
        /// <param name="inner">Association de l'exception</param>
        public ORMExceptionsConnection(string message, Exception inner)
        {
        }
    }

    /// <summary>
    /// Exceptions liées aux déconnexions
    /// </summary>
    public class ORMExceptionsDeconnection : Exception
    {

        /// <summary>
        /// Initialise une nouvelle instance de la class <see cref="T:ORMProjet.Exceptions.ORMExceptionsDeconnection"/>.
        /// </summary>
        public ORMExceptionsDeconnection()
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la class <see cref="T:ORMProjet.Exceptions.ORMExceptionsDeconnection"/>.
        /// </summary>
        /// <param name="message">Message d'erreur à retourner.</param>
        public ORMExceptionsDeconnection(string message) : base(message)
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la class <see cref="T:ORMProjet.Exceptions.ORMExceptionsDeconnection"/>.
        /// </summary>
        /// <param name="message">Message d'erreur à retourner.</param>
        /// <param name="inner">Association de l'exception, de base, complète.</param>
        public ORMExceptionsDeconnection(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
