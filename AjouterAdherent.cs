using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUDOGAMM
{
    public partial class AjouterAdherent : Form 
       //partial signifie que la classe est définie
       // à plusieurs endroits. Ici vous ne voyez que ce que vous devez toucher.
       // L'autre partie de la classe a été faite automatiquement et se charge du reste.
    {
        public AjouterAdherent()
        {
            InitializeComponent();
            //constructeur, la méthode InitializeComponent() est appelée. Elle est créée
            //dans une autre partie de la classe Form1 située dans Form1.Designer.cs
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ancre le bouton dans le coin inférieur droit
            button1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right); 
            button1.Text = "Valider";
            button1.BackColor = Color.OrangeRed;
            MessageBox.Show("test");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.GridColor = Color.Black;
            this.dataGridView1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void SetUpDataGridView()
        {
            this.Controls.Add(dataGridView1);
            dataGridView1.ColumnCount = 10;
            DataGridViewCellStyle style =
                dataGridView1.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.OrangeRed;
            style.ForeColor = Color.Black;
            style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Name = "Ajouter adhérent";
            dataGridView1.Location = new Point(8, 8);
            dataGridView1.Size = new Size(500, 400);
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Raised;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.RowHeadersVisible = true;

            dataGridView1.Columns[0].Name = "Nom";
            dataGridView1.Columns[1].Name = "Prénom";
            //dataGridView1.Columns[1].DefaultCellStyle.Alignment =
            //    DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Name = "ID Adhérent";
            dataGridView1.Columns[3].Name = "Adresse";
            dataGridView1.Columns[4].Name = "Email";
            dataGridView1.Columns[5].Name = "Téléphone";

            dataGridView1.Columns[6].Name = "Adhérent secondaire1";
            dataGridView1.Columns[7].Name = "Adhérent secondaire2";
            dataGridView1.Columns[8].Name = "Adhérent secondaire3";
            dataGridView1.Columns[9].Name = "Adhérent secondaire4";
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<string> nList = new List<string>();
            nList.Add("Gérer les emprunts");
            nList.Add("Gérer les adhérents");
            nList.Add("Gérer les stocks");
        }

        // Gère la fermeture du formulaire par l'utilisateur
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr(e) de vouloir quitter ?", "Demande de confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
