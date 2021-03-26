using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock
{
    class Articles
    {
        private int id;
        private string refSte;
        private string refFrs;
        private string nom;
        private string description;
        private string emplacement;
        private int stockMini;
        private int stockMaxi;
        private int quantite;
        private int idFrs;

        public int Id { get => id; set => id = value; }
        public string RefSte { get => refSte; set => refSte = value; }
        public string RefFrs { get => refFrs; set => refFrs = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        public string Emplacement { get => emplacement; set => emplacement = value; }
        public int StockMini { get => stockMini; set => stockMini = value; }
        public int StockMaxi { get => stockMaxi; set => stockMaxi = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public int IdFrs { get => idFrs; set => idFrs = value; }

        public Articles(int _id, string _refSte, string _refFrs, string _nom, string _description, string _emplacement, int _stockMini, int _stockMaxi, int _quantite, int _idFrs)
        {
            Id = _id;
            RefSte = _refSte;
            refFrs = _refFrs;
            Nom = _nom;
            description = _description;
            emplacement = _emplacement;
            stockMini = _stockMini;
            stockMaxi = _stockMaxi;
            quantite = _quantite;
            idFrs = _idFrs;
        }

        public Articles(string _refSte, string _refFrs, string _nom, string _description, string _emplacement, int _stockMini, int _stockMaxi, int _quantite, int _idFrs)
        {
            RefSte = _refSte;
            refFrs = _refFrs;
            Nom = _nom;
            description = _description;
            emplacement = _emplacement;
            stockMini = _stockMini;
            stockMaxi = _stockMaxi;
            quantite = _quantite;
            idFrs = _idFrs;
        }
    }
}
