using LUDOGAMM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace LUDOGAMM
{


    class GererAdherentSQL 
    {

        public static void CreerAdherent(string nom, string prenom, string rue, string ville, int codePostal, string mail, string telephone)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "INSERT INTO LUDOTHEQUE.dbo.ADHERENT(nom,prenom,rue,ville,codePostal,mail,telephone)VALUES(@nom,@prenom,@rue,@ville,@cp,@mail,@tel)";
            // Définition de la requête
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@rue", rue);
            command.Parameters.AddWithValue("@ville", ville);
            command.Parameters.AddWithValue("@cp", codePostal);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@tel", telephone);

            // Exécution de la requête
            command.ExecuteNonQuery();
        }


    }
}
