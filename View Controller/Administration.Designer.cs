namespace LUDOGAMM
{
    partial class Administration
    {


        private System.Windows.Forms.DataGridViewTextBoxColumn prixCotisationF;
        private System.Windows.Forms.Button Valider_ButtonF;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Valider_ButtonF = new System.Windows.Forms.Button();
            this.dateFinF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebutF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeEmpruntF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbJeuxEmpruntableF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeAdhesionF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixCotisationF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixCautionF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridAdminF = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminF)).BeginInit();
            this.SuspendLayout();
            // 
            // Valider_ButtonF
            // 
            this.Valider_ButtonF.Location = new System.Drawing.Point(620, 224);
            this.Valider_ButtonF.Name = "Valider_ButtonF";
            this.Valider_ButtonF.Size = new System.Drawing.Size(75, 23);
            this.Valider_ButtonF.TabIndex = 2;
            this.Valider_ButtonF.Text = "Valider";
            this.Valider_ButtonF.UseVisualStyleBackColor = true;
            this.Valider_ButtonF.Click += new System.EventHandler(this.ValiderClick);
            // 
            // dateFinF
            // 
            this.dateFinF.HeaderText = "Date de fin";
            this.dateFinF.Name = "dateFinF";
            // 
            // dateDebutF
            // 
            this.dateDebutF.HeaderText = "Date de début";
            this.dateDebutF.Name = "dateDebutF";
            // 
            // dureeEmpruntF
            // 
            this.dureeEmpruntF.HeaderText = "Durée de l\'emprunt (en jours)";
            this.dureeEmpruntF.Name = "dureeEmpruntF";
            // 
            // nbJeuxEmpruntableF
            // 
            this.nbJeuxEmpruntableF.HeaderText = "Nombre de jeux empruntable simultanément";
            this.nbJeuxEmpruntableF.Name = "nbJeuxEmpruntableF";
            // 
            // dureeAdhesionF
            // 
            this.dureeAdhesionF.HeaderText = "Durée de l\'adhésion (en jours)";
            this.dureeAdhesionF.Name = "dureeAdhesionF";
            // 
            // PrixCotisationF
            // 
            this.PrixCotisationF.HeaderText = "Prix de la cotisation";
            this.PrixCotisationF.Name = "PrixCotisationF";
            // 
            // prixCautionF
            // 
            this.prixCautionF.HeaderText = "Prix de la caution";
            this.prixCautionF.Name = "prixCautionF";
            // 
            // dataGridAdminF
            // 
            this.dataGridAdminF.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridAdminF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdminF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prixCautionF,
            this.PrixCotisationF,
            this.dureeAdhesionF,
            this.nbJeuxEmpruntableF,
            this.dureeEmpruntF,
            this.dateDebutF,
            this.dateFinF});
            this.dataGridAdminF.Location = new System.Drawing.Point(194, 69);
            this.dataGridAdminF.Name = "dataGridAdminF";
            this.dataGridAdminF.Size = new System.Drawing.Size(609, 135);
            this.dataGridAdminF.TabIndex = 1;
            this.dataGridAdminF.Text = "dataGridView1";
            this.dataGridAdminF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Valider_ButtonF);
            this.Controls.Add(this.dataGridAdminF);
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.Controls.SetChildIndex(this.dataGridAdminF, 0);
            this.Controls.SetChildIndex(this.Valider_ButtonF, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebutF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeEmpruntF;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbJeuxEmpruntableF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeAdhesionF;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixCotisationF;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixCautionF;
        private System.Windows.Forms.DataGridView dataGridAdminF;
    }
}