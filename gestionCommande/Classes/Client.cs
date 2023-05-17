using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCommande.Classes
{
    /* 1 */
    public class Client
    {
        private int codeCli; //id du client (unique à incremener à chaque ajout)
        // "id" dans le devoir
        private string nomCli, prenomCli;
        // "nom" et "prenom" dans le devoir
        private DateTime dateNaissCli; //n'est pas obligatoire
        // absent dans le devoir
        static int nombreCli = 1; // il contiendra le nombre de clients existant

        /* 3 */
        public static List<Client> listCli = new List<Client>();



        /* 2 */
        public Client(string nomCli, string prenomCli)
        {
            this.codeCli = nombreCli;
            this.nomCli = nomCli;
            this.prenomCli = prenomCli;
            nombreCli++;
        }
        // public Client(int codeCli, string nomCli, string prenomCli, DateTime dateNaissCli)
        // {
        //     this.codeCli = codeCli;
        //     this.nomCli = nomCli;
        //     this.prenomCli = prenomCli;
        //     this.dateNaissCli = dateNaissCli;
        // }

        public int CodeCli
        {
            get { return this.codeCli; }
            set { this.codeCli = value; }
        }

        public string NomCli
        {
            get { return this.nomCli; }
            set { this.nomCli = value; }
        }

        public string PrenomCli
        {
            get { return this.prenomCli; }
            set { this.prenomCli = value; }
        }

        public DateTime DateNaissCli
        {
            get { return this.dateNaissCli; }
            set { this.dateNaissCli = value; }
        }

        /* 6 */
        public double totalCommande()
        {
            double total = 0;
            foreach (Commande com in Commande.listCom)
            {
                if (com.CliCom == this){
                    total += com.totalCommande();
                }
            }
            return total;
        }

        public string nomComplet()
        {
            return nomCli + " " + prenomCli;
        }

        /* 9 */
        public string toString()
        {
            return $"Client n° {this.CodeCli} : {this.nomCli} {this.prenomCli}, Total commandes : " + this.totalCommande() + " F";
        }
    }
}
