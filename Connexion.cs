using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace LUDOGAMM
{
    class Connexion
    {
        private static SqlConnection LaConnexion { get; set; } = null;

        public static SqlConnection GetInstance()
        {
            // Préparation de la connexion à la base de données
            if (LaConnexion == null)
            {
                string connectionString = "Data Source=DESKTOP-7O2DRQE\\SQLEXPRESS;Initial Catalog=LUGOGAMM;User Id=Mireille;Password=sio;";
                LaConnexion = new SqlConnection(connectionString);
                try
                {
                    // Connexion à la base de données
                    LaConnexion.Open();
                    Console.WriteLine("connecté");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("PROBLEME " + ex.Message);
                }
            }
            return LaConnexion;
        }

        private Connexion() { }

       

    }
}


