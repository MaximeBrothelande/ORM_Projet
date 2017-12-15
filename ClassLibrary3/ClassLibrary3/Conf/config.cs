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
    /// <summary>
    /// Gestion des paramètres de la requête SQL
    /// </summary>
    public class DboParameter
    {
        public String Key { get; set; }
        public String Value { get; set; }

        private Type[] typeAccepted =
        {
            typeof(Char),
            typeof(Byte),
            typeof(Int16),
            typeof(Int32),
            typeof(Int64),
            typeof(UInt16),
            typeof(UInt32),
            typeof(UInt64),
            typeof(String),
            typeof(Boolean),
            typeof(DateTime)
        };

        /// <summary>
        /// Associer une valeur a une clé
        /// </summary>
        /// <param name="key">Clé du paramètre</param>
        /// <param name="value">Valeur du paramètre</param>
        public DboParameter(String key, object value)
        {
            this.Key = key;
            // Teste de la présence du type
            if (Test(value.GetType()))
            {
                if (value.GetType().Equals(typeof(DateTime)))
                {
                    DateTime d = (DateTime)value;
                    this.Value = d.Year + "-" + d.Month + "-" + d.Day + " " + d.Hour + ":" + d.Minute + ":" + d.Second;
                }
                else if (value.GetType().Equals(typeof(String)))
                {
                    this.Value = EscapeParam((String)value);
                }
                else if (value.GetType().Equals(typeof(Boolean)))
                {
                    this.Value = ChangeBoolean((Boolean)value);
                }
                else
                {
                    this.Value = value.ToString();
                }
            }
            else
            {
                throw new Exception();
            }
        }

        private String EscapeParam(String param)
        {
            throw new NotImplementedException();
        }

        private string ChangeBoolean(bool value)
        {
            throw new NotImplementedException();
        }
    }
}
