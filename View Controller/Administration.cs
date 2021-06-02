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
    public partial class Administration : MenuView
    {
        public bool estAjoute;

        public int prixCotisation;
        public int prixCaution;
        public int dureeAdhesion;
        public int nbJeuxEmpruntable;
        public int dureeEmprunt;
        public string dateDebut;
        public string dateFin;
        
        public Administration()
        {
            InitializeComponent();
        }

        private bool AjouterAdministrationBDD(SqlCommand bdd, int prixCotisation, int prixCaution, int dureeAdhesion, int nbJeuxEmpruntable, int dureeEmprunt, string dateDebut, string dateFin)
        {
            estAjoute = true;

            // Définition de la requête.
            bdd.CommandText = "INSERT INTO LUDOTHEQUE.dbo.ADMINISTRATION(prixCotisation,prixCaution,dureeAdhesion, nbJeuxEmpruntable, dureeEmprunt, dateDebut, dateFin)VALUES(@prixcotisation,@prixCaution,@dureeAdhesion,@nbJeuxEmpruntable,@dureeEmprunt,@dateDebut,@dateFin)";

            // Définition des paramètres de la requête.
            bdd.Parameters.AddWithValue("@prixCotisation", prixCotisation);
            bdd.Parameters.AddWithValue("@prixCaution", prixCaution);
            bdd.Parameters.AddWithValue("@dureeAdhesion", dureeAdhesion);
            bdd.Parameters.AddWithValue("@nbJeuxEmpruntable", nbJeuxEmpruntable);
            bdd.Parameters.AddWithValue("@dureeEmprunt", dureeEmprunt);
            bdd.Parameters.AddWithValue("@dateDebut", dateDebut);
            bdd.Parameters.AddWithValue("@dateFin", dateFin);
            
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

        private string GetAdministration(SqlCommand bdd, int prixCotisation, int prixCaution, int dureeAdhesion, int nbJeuxEmpruntable, int dureeEmprunt, string dateDebut, string dateFin)
        {
            // Définition de la requête.
            bdd.CommandText = "SELECT ADMINISTRATION.idAbonnement FROM ADRESSE where prixCotisation = @prixCotisation and prixCaution = @prixCaution and dureeAdhesion = @dureeAdhesion and nbJeuxEmpruntable = @nbJeuxEmpruntable and dureeEmprunt = @dureeEmprunt and dateDebut = @dateDebut and dateFin = @dateFin ";
            string idAabonnement = null;

            try
            {
                using (SqlDataReader reader = bdd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idAabonnement = String.Format("{0}", reader["idAabonnement"]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Requete invalide: " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idAabonnement;
        }

        private bool AjouterAdministration()
        {
            // 1 Réupérer les données.
            // 2 Vérifier les infos rentrées par l'utilisateur.
            // 3 Si ok -> requete SQL
            //   Sinon -> message d'erreur et on ne fait rien.
            // 3.1 Verifier le retour de la requete
            //     Si ok -> Message "bien enregistré"
            //     Sinon -> message d'erreur et on ne fait rien.
            string prixCotisation = dataGridAdminF.Rows[0].Cells[0].Value.ToString();
            string prixCaution = dataGridAdminF.Rows[0].Cells[1].Value.ToString();
            string dureeAdhesion = dataGridAdminF.Rows[0].Cells[2].Value.ToString();
            string nbJeuxEmpruntable = dataGridAdminF.Rows[0].Cells[3].Value.ToString();
            string dureeEmprunt = dataGridAdminF.Rows[0].Cells[4].Value.ToString();
            string dateDebut = dataGridAdminF.Rows[0].Cells[5].Value.ToString();
            string dateFin = dataGridAdminF.Rows[0].Cells[6].Value.ToString();



            estAjoute = true;

            if (!String.IsNullOrEmpty(prixCotisation) && !String.IsNullOrEmpty(prixCaution) &&
                !String.IsNullOrEmpty(dureeAdhesion) && !String.IsNullOrEmpty(nbJeuxEmpruntable) && !String.IsNullOrEmpty(dureeEmprunt) && !String.IsNullOrEmpty(dateDebut) && !String.IsNullOrEmpty(dateFin))
            {
                SqlCommand bdd = Connexion.GetInstance().CreateCommand();

                if (bdd != null)
                {



                    // Ajout de l'adresse dans la base de donnée + adhérent + date adhésion
                    _ = AjouterAdministrationBDD(bdd, Convert.ToInt32(prixCotisation), Convert.ToInt32(prixCaution), Convert.ToInt32(dureeAdhesion), Convert.ToInt32(nbJeuxEmpruntable), Convert.ToInt32(dureeEmprunt), dateDebut, dateFin);
                    string idAbonnement = GetAdministration(bdd, Convert.ToInt32(prixCotisation), Convert.ToInt32(prixCaution), Convert.ToInt32(dureeAdhesion), Convert.ToInt32(nbJeuxEmpruntable), Convert.ToInt32(dureeEmprunt), dateDebut, dateFin);

                    



                    estAjoute = AjouterAdministrationBDD(bdd, Convert.ToInt32(prixCotisation), Convert.ToInt32(prixCaution), Convert.ToInt32(dureeAdhesion), Convert.ToInt32(nbJeuxEmpruntable), Convert.ToInt32(dureeEmprunt), dateDebut, dateFin);


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
                // requeste SQL
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
            // Ancre le bouton dans le coin inférieur droit
            Valider_ButtonF.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            Valider_ButtonF.Text = "Valider";
            Valider_ButtonF.BackColor = Color.Blue;

            if (AjouterAdministration())
            {
                MessageBox.Show("Adhérent enregistré!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Adhérent non enregistré!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Administration_Load(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridAdminF.GridColor = Color.Black;
            this.dataGridAdminF.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(dataGridAdminF);
            dataGridAdminF.ColumnCount = 10;
            DataGridViewCellStyle style =
                dataGridAdminF.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.OrangeRed;
            style.ForeColor = Color.Black;
            style.Font = new Font(dataGridAdminF.Font, FontStyle.Bold);

            dataGridAdminF.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridAdminF.Name = "Ajouter administration";
            dataGridAdminF.Location = new Point(8, 8);
            dataGridAdminF.Size = new Size(500, 400);
            dataGridAdminF.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridAdminF.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridAdminF.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridAdminF.GridColor = SystemColors.ActiveBorder;
            dataGridAdminF.RowHeadersVisible = true;

            dataGridAdminF.Columns[0].Name = "prixCotisation";
            dataGridAdminF.Columns[1].Name = "prixCaution";
            dataGridAdminF.Columns[2].Name = "dureeAdhesion";
            dataGridAdminF.Columns[3].Name = "nbJeuxEmpruntable";
            dataGridAdminF.Columns[4].Name = "dureeEmprunt";
            dataGridAdminF.Columns[5].Name = "dateDebut";
            dataGridAdminF.Columns[6].Name = "dateFin";
        }

    }
}
