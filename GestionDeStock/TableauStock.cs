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
    public partial class TableauStock : Form
    {
        public TableauStock()
        {
            InitializeComponent();
        }

        private void FormStocks_Load(object sender, EventArgs e)
        {

        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            textBoxReferenceSociete.Text = "";
            textBoxNomArticle.Text = "";
            textBoxQuantite.Text = "";
            textBoxEmplacement.Text = "";
            textBoxDecriptionArticle.Text = "";
            textBoxStockMini.Text = "";
            textBoxStockMaxi.Text = "";
            textBoxNomFournisseur.Text = "";
            textBoxReferenceFournisseur.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            AjoutArticles fenAjoutArticles = new AjoutArticles();
            DialogResult Fermetrure = fenAjoutArticles.DialogResult;

        }
    }
}
