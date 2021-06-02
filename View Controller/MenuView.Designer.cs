
namespace LUDOGAMM
{
    partial class MenuView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Administration");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ajouter adhérent");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Liste adhérents");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Adhérent", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Ajouter un exemplaire");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Liste jeux");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ajouter un modèle jeu");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Gérer modèle");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Jeu", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.treeView1.Location = new System.Drawing.Point(-3, 46);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Emprunts";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "Administration";
            treeNode2.Name = "AjoutAdhérent";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode2.Text = "Ajouter adhérent";
            treeNode3.Name = "Liste";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode3.Text = "Liste adhérents";
            treeNode4.Name = "Adhérents";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode4.Text = "Adhérent";
            treeNode5.Name = "exemplaire";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode5.Text = "Ajouter un exemplaire";
            treeNode6.Name = "ListeJ";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode6.Text = "Liste jeux";
            treeNode7.Name = "AjouterModele";
            treeNode7.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode7.Text = "Ajouter un modèle jeu";
            treeNode8.Name = "GérerModele";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode8.Text = "Gérer modèle";
            treeNode9.Name = "Stock";
            treeNode9.NodeFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode9.Text = "Jeu";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(191, 404);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
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
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(-3, -2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(806, 51);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "   LUDOTHEQUE";
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.Load += new System.EventHandler(this.MenuView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public event System.Windows.Forms.TreeNodeMouseClickEventHandler NodeMouseClick;
    }
}