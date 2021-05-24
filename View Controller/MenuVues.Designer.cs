
namespace LUDOGAMM.View_Controller
{
    partial class MenuVues
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ajouter Emprunt");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Retour");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Réservations");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Gérer Emprunts", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Ajouter adhérent");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ajouter Adhérent", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ajouter un exemplaire");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Ajouter un modèle jeu");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Gérer modèle");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Gérer Stock", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.treeView1.Location = new System.Drawing.Point(-3, 67);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Ajouter";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "Ajouter Emprunt";
            treeNode2.Name = "Retour";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode2.Text = "Retour";
            treeNode3.Name = "Réservations";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode3.Text = "Réservations";
            treeNode4.Name = "Emprunts";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode4.Text = "Gérer Emprunts";
            treeNode5.Name = "AjoutAdhérent";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode5.Text = "Ajouter adhérent";
            treeNode6.Name = "Adhérents";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode6.Text = "Ajouter Adhérent";
            treeNode7.Name = "exemplaire";
            treeNode7.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode7.Text = "Ajouter un exemplaire";
            treeNode8.Name = "AjouterModele";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode8.Text = "Ajouter un modèle jeu";
            treeNode9.Name = "GérerModele";
            treeNode9.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode9.Text = "Gérer modèle";
            treeNode10.Name = "Stock";
            treeNode10.NodeFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode10.Text = "Gérer Stock";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(193, 383);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1048, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "LUDOTHEQUE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(-3, -2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(806, 71);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "   LUDOTHEQUE";
            // 
            // MenuVues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MenuVues";
            this.Text = "MenuVues";
            this.Load += new System.EventHandler(this.MenuVues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}