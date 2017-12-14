using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_ORM.Exception;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace ClassLibrary3.Connexion
{
    class ORMSqlServer
    {
        SqlConnection connection;

        /// <summary>
        /// Préparation de la connexion
        /// </summary>
        /// <param name="connectionString"> Chaine de connexion au serveur SQLServer</param>
        public ORMSqlServer(String connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Connexion à la base de donnée
        /// </summary>
        /// <returns>
        /// True si la connexion es réussie, False sinon
        /// </returns>
        public Boolean Connection()
        {
            try
            {
                // Si la connexion est "fermée" alors on "l'ouvre"
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 4060:
                        throw new ORMExceptionsConnection("Impossible d'ouvrir la base de donnée demandée par le login. La connexion a échoué.", ex);
                        return false;
                    case 40613:
                        throw new ORMExceptionsConnection("La base de données sur le serveur n'est pas disponible actuellement. Veuillez réessayer la connexion plus tard. Si le problème persiste, contactez le service client.", ex);
                        return false;
                    case 40852:
                        throw new ORMExceptionsConnection(" Impossible d'ouvrir la base de données sur le serveur demandé par le login. L'accès à la base de données est uniquement autorisé à l'aide d'une chaîne de connexion sécurisée.", ex);
                        return false;
                    default:
                        return false;
                }
            }
        }

        /// <summary>
        /// Deconnexion de la base
        /// </summary>
        /// <returns>
        /// True lorsque la deconnexion est effectuée, False sinon
        /// </returns>
        public Boolean Disconnection()
        {
            try
            {
                // Fermeture de la connexion
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                throw new ORMExceptionsDeconnectionSqlServer("Erreur de connexion a SQL Server", ex);
                return false;
            }
        }
}






