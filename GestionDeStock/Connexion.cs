using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionDeStock
{
    public partial class Connexion : Form
    {
        DbConnexions baseConnexion;
        string sonMdp="";
        public Connexion()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            if (textBoxMdp.Text != sonMdp)
            {
                MessageBox.Show("Vous avez saisie un mauvais mot de passe !");
            }
            else
            {
                TableauStock fenTableauStock = new TableauStock();
                DialogResult Fermeture = fenTableauStock.ShowDialog();
            }
        }

        private void textBoxIdent_Leave(object sender, EventArgs e)
        {
            baseConnexion = new DbConnexions();
            MySqlDataReader readerCo = baseConnexion.LectureIdent(textBoxIdent.Text);

            if (readerCo != null)          // on teste si la requete a bien retournéer un résultat
            {
                // Vérifie si des données sont présente dans reader
                if (readerCo.HasRows)
                {
                    readerCo.Read();
                    textBoxNom.Text = readerCo.GetString(3);
                    textBoxPrenom.Text = readerCo.GetString(4);
                    sonMdp = readerCo.GetString(2);

                }
                else
                {
                    MessageBox.Show("L'identifiant saisie n'existe pas !");
                }
            }
            else
            {
                MessageBox.Show("L'identifiant saisie n'existe pas !");
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
