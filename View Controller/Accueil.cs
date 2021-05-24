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
    public partial class Accueil : Form
    //partial signifie que la classe est définie
    // à plusieurs endroits. Ici vous ne voyez que ce que vous devez toucher.
    // L'autre partie de la classe a été faite automatiquement et se charge du reste.
    {
        public Accueil()
        {
            InitializeComponent();
            //MessageBox.Show();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            m_ok.Text = "Ok";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }



        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
