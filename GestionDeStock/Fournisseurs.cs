using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock
{
    class Fournisseurs
    {
        private int id;
        private string nom;
        private string adresse;
        private string cp;
        private string ville;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => cp; set => cp = value; }
        public string Cp { get => ville; set => ville = value; }
        public string Ville { get => cp; set => cp = value; }

        public Fournisseurs(int _id, string _nom, string _adresse, string _cp, string _ville)
        {
            Id = _id;
            Nom = _nom;
            adresse = _adresse;
            cp = _cp;
            ville = _ville;
        }

        public Fournisseurs(string _nom, string _adresse, string _cp, string _ville)
        {
        Nom = _nom;
        adresse = _adresse;
        cp = _cp;
        ville = _ville;
        }
    }
}
