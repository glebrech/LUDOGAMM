using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LUDOGAMM
{
    public partial class Adherents : MenuView
       //partial signifie que la classe est définie
       // à plusieurs endroits. Ici vous ne voyez que ce que vous devez toucher.
       // L'autre partie de la classe a été faite automatiquement et se charge du reste.
    {
        // Gère la fermeture du formulaire par l'utilisateur
        //private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Etes-vous sûr(e) de vouloir quitter ?", "Demande de confirmation",
        //        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        public bool cotisation = false;
        public bool caution = false;

        public bool estAjoute;

        public string nom;
        public string prenom;
        public string rue;
        public int codePostal;
        public string ville;
        public string email;
        public int telephone;
        public string adherentsSecondaires;
        public int idAdresse;
        public int idAdherent;
        public int idAbonnement;


        public Adherents()
        {
            // Constructeur : initialise tout ce qui ce trouve sur la vue.
            InitializeComponent();
        }

        private bool AjouterAdresseBDD(SqlCommand bdd, string rue, string codePostal, string ville)
        {
            estAjoute = true;

            // Définition de la requête.
            bdd.CommandText = "INSERT INTO LUDOTHEQUE.dbo.ADRESSE(rue,codePostal,ville)VALUES(@rue,@codePostal,@ville)";

            // Définition des paramètres de la requête.
            bdd.Parameters.AddWithValue("@rue", rue);
            bdd.Parameters.AddWithValue("@codePostal", codePostal);
            bdd.Parameters.AddWithValue("@ville", ville);

            // Exécution de la requête
            try
            {
                bdd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                estAjoute = false;
                MessageBox.Show("Requete invalide: " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return estAjoute;
        }

        private string GetIdAdresse(SqlCommand bdd ,string rue, string codePostal, string ville)
        {
            // Définition de la requête.
            bdd.CommandText = "SELECT ADRESSE.idAdresse FROM ADRESSE where rue = @rue and codePostal = @codePostal and ville = @ville ";
            string idAdresse = null;

            try
            {
                using (SqlDataReader reader = bdd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idAdresse = String.Format("{0}", reader["idAdresse"]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Requete invalide: " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idAdresse;
        }

        private bool AjouterAdherentBDD(SqlCommand bdd, string idAdresse, string nom, string prenom, string email, string telephone, string adherentsSecondaires)
        {
            bool estAjoute = true;

            // Définition de la requête.
            bdd.CommandText = "INSERT INTO LUDOTHEQUE.dbo.ADHERENT(idAdresse,Nom,Prenom,Email,Telephone,AdherentsSecondaires)VALUES(@idAdresse,@nom,@prenom,@email,@tel,@adherentsSecondaires)";

            // Définition des paramètres de la requête.
            bdd.Parameters.AddWithValue("@idAdresse", idAdresse);
            bdd.Parameters.AddWithValue("@nom", nom);
            bdd.Parameters.AddWithValue("@prenom", prenom);
            bdd.Parameters.AddWithValue("@email", email);
            bdd.Parameters.AddWithValue("@tel", telephone);
            bdd.Parameters.AddWithValue("@adherentsSecondaires", adherentsSecondaires);

            // Exécution de la requête
            try
            {
                bdd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                estAjoute = false;
                MessageBox.Show("Requete invalide: " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return estAjoute;
        }


        private string GetIdAdherent(SqlCommand bdd, string nom,string prenom)
        {
            // Définition de la requête.
            bdd.CommandText = "SELECT ADHERENT.idAdherent FROM ADHERENT WHERE ADHERENT.Nom = @nom AND Prenom = @prenom";

            string idAdherent = null;

            try
            {
                using (SqlDataReader reader = bdd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idAdherent = String.Format("{0}", reader["idAdherent"]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Requete invalide: " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idAdherent;
        }


        private bool AjouterAdhesionBDD(SqlCommand bdd,string idAdherent,bool cotisation, bool caution, string dateDebut)
        {
             
            estAjoute = true;

            // Définition de la requête.
            bdd.CommandText = "INSERT INTO LUDOTHEQUE.dbo.ADHESION(idAdherent,cotisation,caution,debutAdhesion)VALUES(@idAdherent,@cotisation,@caution,@debutAdhesion)";

            bdd.Parameters.AddWithValue("@caution", caution);
            bdd.Parameters.AddWithValue("@cotisation", cotisation);
            bdd.Parameters.AddWithValue("@idAdherent", idAdherent);
            bdd.Parameters.AddWithValue("@debutAdhesion", dateDebut);

            // Définition des paramètres de la requête.

            // Exécution de la requête
            try
            {
                bdd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                estAjoute = false;
                MessageBox.Show("Requete invalide: " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return estAjoute;
        }



        private bool AjouterAdherents()
        {
            // 1 Réupérer les données.
            // 2 Vérifier les infos rentrées par l'utilisateur.
            // 3 Si ok -> requete SQL
            //   Sinon -> message d'erreur et on ne fait rien.
            // 3.1 Verifier le retour de la requete
            //     Si ok -> Message "bien enregistré"
            //     Sinon -> message d'erreur et on ne fait rien.
            string nom = dataGridAdherentPrincipal.Rows[0].Cells[0].Value.ToString();
            string prenom = dataGridAdherentPrincipal.Rows[0].Cells[1].Value.ToString();
            string rue = dataGridAdherentPrincipal.Rows[0].Cells[2].Value.ToString();
            string codePostal = dataGridAdherentPrincipal.Rows[0].Cells[3].Value.ToString();
            string ville = dataGridAdherentPrincipal.Rows[0].Cells[4].Value.ToString();
            string email = dataGridAdherentPrincipal.Rows[0].Cells[5].Value.ToString();
            string telephone = dataGridAdherentPrincipal.Rows[0].Cells[6].Value.ToString();

            string adherent1 = dataGridAdherentsSecondaires.Rows[0].Cells[0].Value.ToString();
            string adherent2 = dataGridAdherentsSecondaires.Rows[0].Cells[1].Value.ToString();
            string adherent3 = dataGridAdherentsSecondaires.Rows[0].Cells[2].Value.ToString();
            string adherent4 = dataGridAdherentsSecondaires.Rows[0].Cells[3].Value.ToString();

            string dateDebut = dataGridAdhesion.Rows[0].Cells[0].Value.ToString();

            estAjoute = true;

            if (!String.IsNullOrEmpty(nom) && !String.IsNullOrEmpty(prenom) &&  
                !String.IsNullOrEmpty(rue) && !String.IsNullOrEmpty(codePostal) && !String.IsNullOrEmpty(ville) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(telephone) &&
                !String.IsNullOrEmpty(adherent1) || !String.IsNullOrEmpty(adherent2) || !String.IsNullOrEmpty(adherent3) || !String.IsNullOrEmpty(adherent4) &&
                !String.IsNullOrEmpty(dateDebut))
            {
                SqlCommand bdd = Connexion.GetInstance().CreateCommand();

                if (bdd != null)
                {



                    // Ajout de l'adresse dans la base de donnée + adhérent + date adhésion
                    _ = AjouterAdresseBDD(bdd, rue, codePostal, ville);
                    string idAdresse = GetIdAdresse(bdd, rue, codePostal, ville);
                    
                    //string idAdherent = GetIdAdherent(bdd);
                    string adherentsSecondaires = (adherent1 + " " + adherent2 + " " + adherent3 + " " + adherent4);
                    _ = AjouterAdherentBDD(bdd,idAdresse, nom, prenom, email, telephone, adherentsSecondaires);


                    string idAdherent = GetIdAdherent(bdd, nom, prenom);

                    estAjoute = AjouterAdhesionBDD(bdd, idAdherent, cotisation, caution,  dateDebut);


                    // Définition des paramètres de la requête





                    // Exécution de la requête
                    try
                    {
                        bdd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        estAjoute = false;
                        MessageBox.Show("Requete invalide: " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    estAjoute = false;
                    MessageBox.Show("La connexion à la bdd a échoué. Merci de réessayer ultérieurement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // requeste SQL
            } else
            {
                estAjoute = false;
                MessageBox.Show("Les informations sont incomplètes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estAjoute;
        }

        private void ValiderClick(object sender, EventArgs e)
        {
            // Ancre le bouton dans le coin inférieur droit
            Valider_Button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right); 
            Valider_Button.Text = "Valider";
            Valider_Button.BackColor = Color.OrangeRed;
            
            if (AjouterAdherents())
            {
                MessageBox.Show("Adhérent enregistré!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Adhérent non enregistré!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




   
            private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void Adherents_Load(object sender, EventArgs e)
        {

        }

        private void Cotisation_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cotisation = true;
        }

        private void Caution_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            caution = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
