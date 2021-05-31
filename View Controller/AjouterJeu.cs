using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LUDOGAMM
{
    public partial class AjouterJeu : MenuView
    {

        public bool estAjoute;
        public int idJeu;
        public string genre;
        public string nom;
        public string auteur;
        public int anneeEdition;
        public string regleJeu;

        public AjouterJeu()
        {
            InitializeComponent();
        }
        private bool AjouterJeuDB(SqlCommand bdd, string genre, string nom, string auteur, string anneeEdition, string editeur, string nbJoueurMini, string nbJoueurMaxi, string ageMini, string ageMaxi, string tempsJeu, string regleJeu)
        {


            estAjoute = true;

            // Définition de la requête.
            bdd.CommandText = "INSERT INTO LUDOTHEQUE.dbo.JEU(genre,titre,auteur,anneeEdition,editeur,nbrJoueurMini,nbrJoueurMaxi,ageMini,ageMaxi,tempsDeJeu,regleDuJeu)VALUES(@genre,@titre,@auteur,@anneeEdition,@editeur,@nbrJoueurMini,@nbrJoueurMaxi,@ageMini,@ageMaxi,@tempsDeJeu,@regleDuJeu)";

            // Définition des paramètres de la requête.
            bdd.Parameters.AddWithValue("@genre", genre);
            bdd.Parameters.AddWithValue("@titre", nom);
            bdd.Parameters.AddWithValue("@auteur", auteur);
            bdd.Parameters.AddWithValue("@anneeEdition", anneeEdition);
            bdd.Parameters.AddWithValue("@editeur", editeur);
            bdd.Parameters.AddWithValue("@nbrJoueurMini", nbJoueurMini);
            bdd.Parameters.AddWithValue("@nbrJoueurMaxi", nbJoueurMaxi);
            bdd.Parameters.AddWithValue("@ageMini", ageMini);
            bdd.Parameters.AddWithValue("@ageMaxi", ageMaxi);
            bdd.Parameters.AddWithValue("@tempsDeJeu", tempsJeu);
            bdd.Parameters.AddWithValue("@regleDuJeu", regleJeu);

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

        private string GetIdJeu(SqlCommand bdd, string genre, string nom, string auteur, string anneeEdition, string editeur, string nbJoueurMini, string nbJoueurMaxi, string ageMini, string ageMaxi, string tempsJeu, string regleJeu)
        {
            // Définition de la requête.
            bdd.CommandText = "SELECT JEU.idJeu FROM JEU where genre = @genre and titre = @titre and auteur = @auteur and anneeEdition = @anneeEdition and editeur = @editeur and nbrJoueurMini = @nbrJoueurMini and nbrJoueurMaxi = @nbrJoueurMaxi and ageMini = @ageMini and ageMaxi = @ageMaxi and tempsDeJeu = @tempsDeJeu and regleDuJeu = @regleDuJeu";
            string idJeu = null;

            try
            {
                using (SqlDataReader reader = bdd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idJeu = String.Format("{0}", reader["idJeu"]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Requete invalide: " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idJeu;
        }

        private bool AjoutDeJeu()
        {
            // 1 Réupérer les données.
            // 2 Vérifier les infos rentrées par l'utilisateur.
            // 3 Si ok -> requete SQL
            //   Sinon -> message d'erreur et on ne fait rien.
            // 3.1 Verifier le retour de la requete
            //     Si ok -> Message "bien enregistré"
            //     Sinon -> message d'erreur et on ne fait rien.
            string genre = dataGridView1.Rows[0].Cells[0].Value.ToString();
            string nom = dataGridView1.Rows[0].Cells[1].Value.ToString();
            string auteur = dataGridView1.Rows[0].Cells[2].Value.ToString();
            string anneeEdition = dataGridView1.Rows[0].Cells[3].Value.ToString();
            string editeur = dataGridView1.Rows[0].Cells[4].Value.ToString();


            string nbJoueurMini = dataGridView2.Rows[0].Cells[0].Value.ToString();
            string nbJoueurMaxi = dataGridView2.Rows[0].Cells[1].Value.ToString();
            string ageMini = dataGridView2.Rows[0].Cells[2].Value.ToString();
            string ageMaxi = dataGridView2.Rows[0].Cells[3].Value.ToString();
            string tempsJeu = dataGridView2.Rows[0].Cells[4].Value.ToString();

            string regleJeu = dataGridView3.Rows[0].Cells[0].Value.ToString();

            estAjoute = true;

            if (!String.IsNullOrEmpty(genre) && !String.IsNullOrEmpty(nom) &&
                !String.IsNullOrEmpty(auteur) && !String.IsNullOrEmpty(anneeEdition) && !String.IsNullOrEmpty(editeur) && !String.IsNullOrEmpty(nbJoueurMini) && !String.IsNullOrEmpty(nbJoueurMaxi) &&
                !String.IsNullOrEmpty(ageMini) || !String.IsNullOrEmpty(ageMaxi) || !String.IsNullOrEmpty(tempsJeu) || !String.IsNullOrEmpty(regleJeu))
            {
                SqlCommand bdd = Connexion.GetInstance().CreateCommand();

                if (bdd != null)
                {



                    // Ajout du jeu dans la base de données
                    _ = AjouterJeuDB(bdd, genre, nom, auteur, anneeEdition, editeur, nbJoueurMini, nbJoueurMaxi, ageMini,  ageMaxi, tempsJeu, regleJeu);
                    string idJeu = GetIdJeu(bdd, genre, nom, auteur, anneeEdition, editeur, nbJoueurMini, nbJoueurMaxi, ageMini, ageMaxi, tempsJeu, regleJeu);



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
                }
                else
                {
                    estAjoute = false;
                    MessageBox.Show("La connexion à la bdd a échoué. Merci de réessayer ultérieurement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                estAjoute = false;
                MessageBox.Show("Les informations sont incomplètes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estAjoute;
        }

        private void ValiderClick(object sender, EventArgs e)
        {

            Valider_Button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            Valider_Button.Text = "Valider";
            Valider_Button.BackColor = Color.Blue;

            if (AjoutDeJeu())
            {
                MessageBox.Show("Le jeu a été ajouté!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Le jeu n'a pas pu être ajouté!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AjouterJeu_Load(object sender, EventArgs e)
        {

        }
    }
}
