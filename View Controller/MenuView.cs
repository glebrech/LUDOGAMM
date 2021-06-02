using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LUDOGAMM
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void MenuView_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {


            if (e.Node.Text == "Ajouter adhérent") {

                var adherent = new Adherents();
                adherent.Show();
                Hide();
            }

            if (e.Node.Text == "Ajouter un exemplaire")
            {

                var jeu = new AjouterJeu();
                jeu.Show();
                Hide();
            }

            if (e.Node.Text == "Administration")
            {

                var admin = new Administration();
                admin.Show();
                Hide();
            }

        }
    }
}
