using System.Windows.Forms;

namespace LUDOGAMM
{
    partial class Adherents
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Valider_Button = new System.Windows.Forms.Button();
            this.Cotisation_CheckBox = new System.Windows.Forms.CheckBox();
            this.Caution_CheckBox = new System.Windows.Forms.CheckBox();
            this.dataGridAdherentPrincipal = new System.Windows.Forms.DataGridView();
            this.idAdherentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridAdherentsSecondaires = new System.Windows.Forms.DataGridView();
            this.Adherent1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adherent2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adherent3Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adherent4Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridAdhesion = new System.Windows.Forms.DataGridView();
            this.dateDebutCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdherentPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdherentsSecondaires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdhesion)).BeginInit();
            this.SuspendLayout();
            // 
            // Valider_Button
            // 
            this.Valider_Button.BackColor = System.Drawing.SystemColors.Window;
            this.Valider_Button.Location = new System.Drawing.Point(718, 547);
            this.Valider_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Valider_Button.Name = "Valider_Button";
            this.Valider_Button.Size = new System.Drawing.Size(92, 32);
            this.Valider_Button.TabIndex = 0;
            this.Valider_Button.Text = "Valider";
            this.Valider_Button.UseVisualStyleBackColor = false;
            this.Valider_Button.Click += new System.EventHandler(this.ValiderClick);
            // 
            // Cotisation_CheckBox
            // 
            this.Cotisation_CheckBox.AutoSize = true;
            this.Cotisation_CheckBox.Location = new System.Drawing.Point(267, 507);
            this.Cotisation_CheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cotisation_CheckBox.Name = "Cotisation_CheckBox";
            this.Cotisation_CheckBox.Size = new System.Drawing.Size(91, 20);
            this.Cotisation_CheckBox.TabIndex = 2;
            this.Cotisation_CheckBox.Text = "Cotisation";
            this.Cotisation_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Caution_CheckBox
            // 
            this.Caution_CheckBox.AutoSize = true;
            this.Caution_CheckBox.Location = new System.Drawing.Point(267, 554);
            this.Caution_CheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Caution_CheckBox.Name = "Caution_CheckBox";
            this.Caution_CheckBox.Size = new System.Drawing.Size(77, 20);
            this.Caution_CheckBox.TabIndex = 3;
            this.Caution_CheckBox.Text = "Caution";
            this.Caution_CheckBox.UseVisualStyleBackColor = true;
            // 
            // dataGridAdherentPrincipal
            // 
            this.dataGridAdherentPrincipal.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridAdherentPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdherentPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAdherentCol,
            this.NomCol,
            this.PrenomCol,
            this.RueCol,
            this.CodePostalCol,
            this.VilleCol,
            this.EmailCol,
            this.TelCol});
            this.dataGridAdherentPrincipal.Location = new System.Drawing.Point(199, 120);
            this.dataGridAdherentPrincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridAdherentPrincipal.Name = "dataGridAdherentPrincipal";
            this.dataGridAdherentPrincipal.RowTemplate.Height = 25;
            this.dataGridAdherentPrincipal.Size = new System.Drawing.Size(708, 100);
            this.dataGridAdherentPrincipal.TabIndex = 10;
            this.dataGridAdherentPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAdherentPrincipal_CellContentClick);
            // 
            // idAdherentCol
            // 
            this.idAdherentCol.HeaderText = "N° Adhérent";
            this.idAdherentCol.Name = "idAdherentCol";
            this.idAdherentCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NomCol
            // 
            this.NomCol.HeaderText = "Nom";
            this.NomCol.Name = "NomCol";
            // 
            // PrenomCol
            // 
            this.PrenomCol.HeaderText = "Prénom";
            this.PrenomCol.Name = "PrenomCol";
            // 
            // RueCol
            // 
            this.RueCol.HeaderText = "Rue";
            this.RueCol.Name = "RueCol";
            // 
            // CodePostalCol
            // 
            this.CodePostalCol.HeaderText = "Code Postal";
            this.CodePostalCol.Name = "CodePostalCol";
            // 
            // VilleCol
            // 
            this.VilleCol.HeaderText = "Ville";
            this.VilleCol.Name = "VilleCol";
            // 
            // EmailCol
            // 
            this.EmailCol.HeaderText = "Email";
            this.EmailCol.Name = "EmailCol";
            // 
            // TelCol
            // 
            this.TelCol.HeaderText = "Téléphone";
            this.TelCol.Name = "TelCol";
            // 
            // dataGridAdherentsSecondaires
            // 
            this.dataGridAdherentsSecondaires.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridAdherentsSecondaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdherentsSecondaires.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adherent1Col,
            this.Adherent2Col,
            this.Adherent3Col,
            this.Adherent4Col});
            this.dataGridAdherentsSecondaires.Location = new System.Drawing.Point(199, 268);
            this.dataGridAdherentsSecondaires.Name = "dataGridAdherentsSecondaires";
            this.dataGridAdherentsSecondaires.RowTemplate.Height = 25;
            this.dataGridAdherentsSecondaires.Size = new System.Drawing.Size(462, 66);
            this.dataGridAdherentsSecondaires.TabIndex = 14;
            this.dataGridAdherentsSecondaires.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAdherentsSecondaires_CellContentClick);
            // 
            // Adherent1Col
            // 
            this.Adherent1Col.HeaderText = "Adhérent1";
            this.Adherent1Col.Name = "Adherent1Col";
            // 
            // Adherent2Col
            // 
            this.Adherent2Col.HeaderText = "Adhérent2";
            this.Adherent2Col.Name = "Adherent2Col";
            // 
            // Adherent3Col
            // 
            this.Adherent3Col.HeaderText = "Adhérent3";
            this.Adherent3Col.Name = "Adherent3Col";
            // 
            // Adherent4Col
            // 
            this.Adherent4Col.HeaderText = "Adhérent4";
            this.Adherent4Col.Name = "Adherent4Col";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 23);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Adhérent principal";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 23);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Adhérents secondaires";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(237, 364);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 23);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "Adhesion";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridAdhesion
            // 
            this.dataGridAdhesion.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridAdhesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdhesion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDebutCol});
            this.dataGridAdhesion.Location = new System.Drawing.Point(199, 404);
            this.dataGridAdhesion.Name = "dataGridAdhesion";
            this.dataGridAdhesion.RowTemplate.Height = 25;
            this.dataGridAdhesion.Size = new System.Drawing.Size(224, 66);
            this.dataGridAdhesion.TabIndex = 14;
            this.dataGridAdhesion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAdhesion_CellContentClick);
            // 
            // dateDebutCol
            // 
            this.dateDebutCol.HeaderText = "Date début";
            this.dateDebutCol.Name = "dateDebutCol";
            this.dateDebutCol.Width = 150;
            // 
            // Adherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(978, 686);
            this.Controls.Add(this.dataGridAdhesion);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridAdherentsSecondaires);
            this.Controls.Add(this.dataGridAdherentPrincipal);
            this.Controls.Add(this.Caution_CheckBox);
            this.Controls.Add(this.Cotisation_CheckBox);
            this.Controls.Add(this.Valider_Button);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Adherents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Adherents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdherentPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdherentsSecondaires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdhesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Valider_Button;
        private System.Windows.Forms.CheckBox Cotisation_CheckBox;
        private System.Windows.Forms.CheckBox Caution_CheckBox;
        private System.Windows.Forms.DataGridView dataGridAdherentPrincipal;
        private System.Windows.Forms.DataGridView dataGridAdherentsSecondaires;
        private System.Windows.Forms.DataGridView dataGridAdhesion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.DataGridViewTextBoxColumn idAdherentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RueCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adherent1Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adherent2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adherent3Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adherent4Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelCol;

        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebutCol;
    }
}

