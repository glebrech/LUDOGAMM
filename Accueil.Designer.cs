namespace LUDOGAMM
{
    partial class Accueil
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Ajouter un emprunt");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Retour");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Réservation");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Gérer les emprunts", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Ajouter un adhérent");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Gérer les adhérents", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Ajouter un exemplaire");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Ajouter un modèle de jeu");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Gérer modèle de jeu");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Gérer le stock", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            this.m_ok = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView3 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ok
            // 
            this.m_ok.AccessibleDescription = "";
            this.m_ok.AccessibleName = "";
            this.m_ok.BackColor = System.Drawing.Color.GhostWhite;
            this.m_ok.Location = new System.Drawing.Point(529, 39);
            this.m_ok.Name = "m_ok";
            this.m_ok.Size = new System.Drawing.Size(31, 23);
            this.m_ok.TabIndex = 0;
            this.m_ok.Text = "Ok";
            this.m_ok.UseVisualStyleBackColor = false;
            this.m_ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Emprunts",
            "Stock",
            "Adhérents"});
            this.comboBox1.Location = new System.Drawing.Point(588, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Filtrer";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Rechercher";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(725, 312);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeView1.Location = new System.Drawing.Point(19, 113);
            this.treeView1.Name = "treeView1";
            treeNode11.ForeColor = System.Drawing.Color.Black;
            treeNode11.Name = "Ajouter";
            treeNode11.Text = "Ajouter un emprunt";
            treeNode12.ForeColor = System.Drawing.Color.Black;
            treeNode12.Name = "Retour";
            treeNode12.Text = "Retour";
            treeNode13.ForeColor = System.Drawing.Color.Black;
            treeNode13.Name = "Réservations";
            treeNode13.Text = "Réservation";
            treeNode14.ForeColor = System.Drawing.Color.Black;
            treeNode14.Name = "Emprunts";
            treeNode14.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode14.Text = "Gérer les emprunts";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(197, 160);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeView2.Location = new System.Drawing.Point(268, 113);
            this.treeView2.Name = "treeView2";
            treeNode15.ForeColor = System.Drawing.Color.Black;
            treeNode15.Name = "Ajouter";
            treeNode15.Text = "Ajouter un adhérent";
            treeNode16.ForeColor = System.Drawing.Color.Black;
            treeNode16.Name = "Adhérents";
            treeNode16.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode16.Text = "Gérer les adhérents";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView2.Size = new System.Drawing.Size(215, 160);
            this.treeView2.TabIndex = 8;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // treeView3
            // 
            this.treeView3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeView3.Location = new System.Drawing.Point(529, 113);
            this.treeView3.Name = "treeView3";
            treeNode17.ForeColor = System.Drawing.Color.Black;
            treeNode17.Name = "Ajouter";
            treeNode17.Text = "Ajouter un exemplaire";
            treeNode18.ForeColor = System.Drawing.Color.Black;
            treeNode18.Name = "modèle";
            treeNode18.Text = "Ajouter un modèle de jeu";
            treeNode19.ForeColor = System.Drawing.Color.Black;
            treeNode19.Name = "gérer";
            treeNode19.Text = "Gérer modèle de jeu";
            treeNode20.ForeColor = System.Drawing.Color.Black;
            treeNode20.Name = "Stock";
            treeNode20.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode20.Text = "Gérer le stock";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.treeView3.Size = new System.Drawing.Size(187, 160);
            this.treeView3.TabIndex = 9;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 429);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.m_ok);
            this.Name = "Accueil";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button m_ok;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView3;
    }
}

// slam

