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
            button1.Text = "valider";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
