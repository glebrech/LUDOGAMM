
namespace LUDOGAMM
{
    partial class AjouterJeu
    {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnneeEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nombreJoueurMini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreJoueurMaxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageMinimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageMaximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsDeJeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.regleDuJeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valider_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Genre,
            this.Jeu,
            this.Auteur,
            this.AnneeEdition,
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(221, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(567, 79);
            this.dataGridView1.TabIndex = 0;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Jeu
            // 
            this.Jeu.HeaderText = "Nom";
            this.Jeu.Name = "Jeu";
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.Name = "Auteur";
            // 
            // AnneeEdition
            // 
            this.AnneeEdition.HeaderText = "Année d\'édition";
            this.AnneeEdition.Name = "AnneeEdition";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Éditeur";
            this.Edit.Name = "Edit";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreJoueurMini,
            this.nombreJoueurMaxi,
            this.ageMinimum,
            this.ageMaximum,
            this.tempsDeJeu});
            this.dataGridView2.Location = new System.Drawing.Point(221, 206);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(567, 114);
            this.dataGridView2.TabIndex = 1;
            // 
            // nombreJoueurMini
            // 
            this.nombreJoueurMini.HeaderText = "Nombre joueur minimum";
            this.nombreJoueurMini.Name = "nombreJoueurMini";
            // 
            // nombreJoueurMaxi
            // 
            this.nombreJoueurMaxi.HeaderText = "Nombre joueur maximum";
            this.nombreJoueurMaxi.Name = "nombreJoueurMaxi";
            // 
            // ageMinimum
            // 
            this.ageMinimum.HeaderText = "Âge minimum";
            this.ageMinimum.Name = "ageMinimum";
            // 
            // ageMaximum
            // 
            this.ageMaximum.HeaderText = "Âge maximum";
            this.ageMaximum.Name = "ageMaximum";
            // 
            // tempsDeJeu
            // 
            this.tempsDeJeu.HeaderText = "Temps de jeu";
            this.tempsDeJeu.Name = "tempsDeJeu";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regleDuJeu});
            this.dataGridView3.Location = new System.Drawing.Point(221, 332);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(207, 76);
            this.dataGridView3.TabIndex = 2;
            // 
            // regleDuJeu
            // 
            this.regleDuJeu.HeaderText = "Règle du jeu";
            this.regleDuJeu.Name = "regleDuJeu";
            // 
            // Valider_Button
            // 
            this.Valider_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Valider_Button.Location = new System.Drawing.Point(713, 406);
            this.Valider_Button.Name = "Valider_Button";
            this.Valider_Button.Size = new System.Drawing.Size(75, 23);
            this.Valider_Button.TabIndex = 3;
            this.Valider_Button.Text = "Valider";
            this.Valider_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Valider_Button.UseVisualStyleBackColor = false;
            this.Valider_Button.Click += new System.EventHandler(this.ValiderClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Informations générales";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Modalités";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AjouterJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Valider_Button);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AjouterJeu";
            this.Text = "AjouterJeu";
            this.Load += new System.EventHandler(this.AjouterJeu_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.dataGridView3, 0);
            this.Controls.SetChildIndex(this.Valider_Button, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn editeur;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbJoueurMini;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbJoueurMaxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageMini;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageMaxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsJeu;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn regleDuJeu;
        private System.Windows.Forms.Button Valider_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnneeEdition;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreJoueurMini;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreJoueurMaxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageMinimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageMaximum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsDeJeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
    }
}