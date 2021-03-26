using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock
{
    class Connexions
    {
        private int id;
        private string ident;
        private string mdp;
        private string nom;
        private string prenom;

        public int Id { get => id; set => id = value; }
        public string Ident { get => ident; set => ident = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public Connexions(int _id, string _ident, string _mdp, string _nom, string _prenom)
        {
            id = _id;
            ident = _ident;
            mdp = _mdp;
            nom = _nom;
            prenom = _prenom;


        }

        public Connexions(string _ident, string _mdp, string _nom, string _prenom)
        {
            ident = _ident;
            mdp = _mdp;
            nom = _nom;
            prenom = _prenom;
        }
    }
}
