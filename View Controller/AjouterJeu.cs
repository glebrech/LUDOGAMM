using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LUDOGAMM
{
    public partial class AjouterJeu : Form
    {
        public AjouterJeu()
        {
            InitializeComponent();
        }
    }
}

    public class AjouterJeu : Form
    {
        private DataGridView dataGridView1 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private Button reloadButton = new Button();
        private Button submitButton = new Button();

    /* A Ajouter l'appel du new AjouterJeu() dans program.cs -> 1 seul Main par projet.
        [STAThread()]
        public static void Main()
        {
            Application.Run(new AjouterJeu());
        }
    */
    // Initialize the form.
    public AjouterJeu()
        {
            dataGridView1.Dock = DockStyle.Fill;

            reloadButton.Text = "Reload";
            submitButton.Text = "Submit";
            //reloadButton.Click += new EventHandler(ReloadButton_Click);
            //submitButton.Click += new EventHandler(SubmitButton_Click);

            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true
            };
            panel.Controls.AddRange(new Control[] { reloadButton, submitButton });

            Controls.AddRange(new Control[] { dataGridView1, panel });
            Load += new EventHandler(AjouterJeu_Load);
            Text = "DataGridView data binding and updating demo";
        }
    private void button1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AjouterJeu_Load(object sender, EventArgs e)
        {

        }
    }
