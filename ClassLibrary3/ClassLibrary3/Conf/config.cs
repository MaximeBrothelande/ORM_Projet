using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_ORM.Conf
{
    class Config
    { 
      /// <summary>
      /// Class : DboConfiguration.cd pour récupérer le type et la connectionString
      /// </summary>
        abstract class DboConfiguration
        {
            /// <summary>
            /// Liste des BDD
            /// </summary>
            public enum TypeSGBD
            {
                SQLSERVER,
                POSTGRESQL,
                MYSQL
            }

            /// <summary>
            /// Récupère le type de base de données
            /// </summary>
            /// <returns>Retourne le type de base de données</returns>
            abstract public TypeSGBD GetDbType();

            /// <summary>
            /// Récupère la connectionString
            /// </summary>
            /// <returns>Retourne la connectionString</returns>
            abstract public string GetConnectionString();
        }
    }
}
