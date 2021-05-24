using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LUDOGAMM
{
    class Connexion
    {
        private Connexion() { }

        private static SqlConnection LaConnexion { get; set; } = null;

        public static SqlConnection GetInstance()
        {
            // Préparation de la connexion à la base de données
            if (LaConnexion == null)
            {
                //string connectionString = "Data Source=DESKTOP-7O2DRQE\\SQLEXPRESS;Initial Catalog=LUDOGAMM;User Id=gwenchlan;Password=sio56;";
                string connectionString = "Data Source=DESKTOP-7O2DRQE\\SQLEXPRESS;Initial Catalog=LUDOTHEQUE;User Id=Mireille;Password=sio;";
                //string connectionString = "Data Source=DESKTOP-7O2DRQE;Initial Catalog=LUDOGAMM;User Id=Antoine;Password=sio";
                //string connectionString = "Data Source=DESKTOP-7O2DRQE;Initial Catalog=Aero; User Id=Marc; Password=sio;";

                LaConnexion = new SqlConnection(connectionString);

                try
                {
                    // Connexion à la base de données
                    LaConnexion.Open();
                    Form dlg1 = new Form();
                    dlg1.ShowDialog();
                    System.Diagnostics.Debug.WriteLine("Co réussie");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("PROBLEME : " + ex.Message);
                }
            } //Commentaire test
            return LaConnexion;
        }
    }
}


