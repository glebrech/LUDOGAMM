using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                //string connectionString = "Data Source=DESKTOP-7O2DRQE\\SQLEXPRESS;Initial Catalog=LUDOTHEQUE;User Id=gwenchlan;Password=sio56;";
                string connectionString = "Data Source=DESKTOP-7O2DRQE\\SQLEXPRESS;Initial Catalog=LUDOTHEQUE;User Id=Mireille;Password=sio;";
                //string connectionString = "Data Source=DESKTOP-7O2DRQE;Initial Catalog=LUDOTHEQUE;User Id=Antoine;Password=sio;";

                                LaConnexion = new SqlConnection(connectionString);
                try
                {
                    // Connexion à la base de données
                    LaConnexion.Open();
                    Form dlg1 = new Form();
                    dlg1.ShowDialog();
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


