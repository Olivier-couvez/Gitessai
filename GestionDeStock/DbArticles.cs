using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace GestionDeStock
{
    class DbArticles
    {
        MySqlDataReader reader;
        Dbconnect Connex;

        public DbArticles()
        {
        }

        public bool AjouterClub(Articles Unarticle)
        {
            bool opeOK = false;
            try
            {


                var ConnectionStrings = ConfigurationManager.ConnectionStrings;
                string bddServeur = Convert.ToString(ConnectionStrings["serveur"]);
                string sBddPort = Convert.ToString(ConnectionStrings["port"]);
                int bddPort = Convert.ToInt16(sBddPort);
                string bddBase = Convert.ToString(ConnectionStrings["base"]);
                string bddIdent = Convert.ToString(ConnectionStrings["identificateur"]);
                string bddMdp = Convert.ToString(ConnectionStrings["mdp"]);

                Connex = new Dbconnect(bddServeur, bddPort, bddBase, bddIdent, bddMdp);
                //Connex = new Dbconnect("secuoli.freeboxos.fr", 3306, "gestioncourses", "amoi", "");
                if (Connex.OuvrirConnexion())
            {
                string requete = "INSERT INTO `article` (`IdArticle`, `RefSociete`, `RefFournisseur`, `Nom`, `Description`, `Emplacement`, `StockMin`, `StockMax`, `Quantite`, `IdFournisseur`)"
                        + "VALUES ('" +Unarticle.RefSte+ "', '" + Unarticle.RefFrs + "', '" + Unarticle.Nom + "', '" + Unarticle.Description + "', '" + Unarticle.Emplacement + "', '" + Unarticle.StockMini + "', '" + Unarticle.StockMaxi + "', '" + Unarticle.Quantite+ "', '" + Unarticle.IdFrs + "')";

                Connex.RequeteNoData(requete);
                opeOK = true;
            }
            }
            catch
            {
                opeOK = false;
            }
            Connex.FermerConnexion();
            return opeOK;
        }

        public (bool, string) ModifierArticle(Articles Unarticle, int IdArticle)
        {
            bool opeOK = false;
            int ligneMod = 0;
            string messErreur ="";
            try
            {


                var ConnectionStrings = ConfigurationManager.ConnectionStrings;
                string bddServeur = Convert.ToString(ConnectionStrings["serveur"]);
                string sBddPort = Convert.ToString(ConnectionStrings["port"]);
                int bddPort = Convert.ToInt16(sBddPort);
                string bddBase = Convert.ToString(ConnectionStrings["base"]);
                string bddIdent = Convert.ToString(ConnectionStrings["identificateur"]);
                string bddMdp = Convert.ToString(ConnectionStrings["mdp"]);

                Connex = new Dbconnect(bddServeur, bddPort, bddBase, bddIdent, bddMdp);
                //Connex = new Dbconnect("secuoli.freeboxos.fr", 3306, "gestioncourses", "amoi", "");
                if (Connex.OuvrirConnexion())
                {
                    string requete = "UPDATE `article` SET `RefSociete` ='" + Unarticle.RefSte + "', `RefFournisseur` = '" + Unarticle.RefFrs + "', `Nom` = '" + Unarticle.Nom 
                        + "', `Description` = '" + Unarticle.Description + "', `Emplacement` = '" + Unarticle.Emplacement + "', `StockMin` = '" 
                        + Unarticle.StockMini + "', `StockMax` = '" + Unarticle.StockMaxi + "', `Quantite` = '" + Unarticle.Quantite + "', `IdFournisseur` = '" 
                        + Unarticle.IdFrs + "' WHERE `article`.`IdArticle` = " +IdArticle;
                    ligneMod = Connex.RequeteNoData(requete);
                    if (ligneMod == 0)
                    {
                        messErreur = Connex.Erreur;
                        opeOK = false;
                    }
                    else
                    {
                        opeOK = true;
                    }
                }
            }
            catch
            {
                opeOK = false;
                messErreur = "Erreur de connexion !";
            }
            Connex.FermerConnexion();
            return (opeOK, messErreur);
        }

        public (bool, string) SupprimerArticle(Articles UnArticle, int IdArticle)
        {
            bool opeOK = false;
            int ligneMod = 0;
            string messErreur="";

            try
            {
                var ConnectionStrings = ConfigurationManager.ConnectionStrings;
                string bddServeur = Convert.ToString(ConnectionStrings["serveur"]);
                string sBddPort = Convert.ToString(ConnectionStrings["port"]);
                int bddPort = Convert.ToInt16(sBddPort);
                string bddBase = Convert.ToString(ConnectionStrings["base"]);
                string bddIdent = Convert.ToString(ConnectionStrings["identificateur"]);
                string bddMdp = Convert.ToString(ConnectionStrings["mdp"]);

                Connex = new Dbconnect(bddServeur, bddPort, bddBase, bddIdent, bddMdp);
                //Connex = new Dbconnect("secuoli.freeboxos.fr", 3306, "gestioncourses", "amoi", "");
                if (Connex.OuvrirConnexion())
                {
                    string requete = "DELETE FROM article WHERE IdArticle = " + IdArticle ;
                    ligneMod = Connex.RequeteNoData(requete);
                    if (ligneMod == 0)
                    {
                        messErreur = Connex.Erreur;
                        opeOK = false;
                    }else
                    {
                        opeOK = true;
                    }
                }
            }
            catch
            {
                opeOK = false;
                messErreur = "Erreur de connexion !";
            }
            Connex.FermerConnexion();
            return (opeOK, messErreur);
        }


        public MySqlDataReader LecturetoutClub()
        {
            try
            {
                var ConnectionStrings = ConfigurationManager.ConnectionStrings;
                string bddServeur = Convert.ToString(ConnectionStrings["serveur"]);
                string sBddPort = Convert.ToString(ConnectionStrings["port"]);
                int bddPort = Convert.ToInt16(sBddPort);
                string bddBase = Convert.ToString(ConnectionStrings["base"]);
                string bddIdent = Convert.ToString(ConnectionStrings["identificateur"]);
                string bddMdp = Convert.ToString(ConnectionStrings["mdp"]);

                Connex = new Dbconnect(bddServeur, bddPort, bddBase, bddIdent, bddMdp);
                //Connex = new Dbconnect("secuoli.freeboxos.fr", 3306, "gestioncourses", "amoi", "");
                if (Connex.OuvrirConnexion())
                {
                    string requete = "SELECT * FROM article";
                    reader = Connex.RequeteSql(requete);
                    return reader;
                }
            }
            catch
            {
                return reader;
            }
            Connex.FermerConnexion();
            return reader;
        }
    }
}
