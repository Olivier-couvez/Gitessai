using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock
{
    public partial class FormAjoutFournisseur : Form
    {
        public FormAjoutFournisseur()
        {
            InitializeComponent();
            textBoxNomFournisseur.Text = "";
            textBoxAdresseFournisseur.Text = "";
            textBoxCPFournisseur.Text = "";
            textBoxVilleFournisseur.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textBoxNomFournisseur.Text = "";
            textBoxAdresseFournisseur.Text = "";
            textBoxCPFournisseur.Text = "";
            textBoxVilleFournisseur.Text = "";
        }
    }
}
