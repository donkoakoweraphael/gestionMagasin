using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCommande.Classes
{
    /* 1 */
    public class Commande
    {
        private int idCom; // unique à incrementer à chaque ajout
        // "idCommande" dans le devoir
        private DateTime dateCom;
        // "dateCommande" dans le devoir
        private Client cliCom; // renvoi vers le client qui a passé la commande
        // "client" dans le devoir
        static int nombreCom = 0; // il contiendra le nombre de commandes existantes

        /* 3 */
        public static List<Commande> listCom = new List<Commande>();

        /* 2 */
        public Commande(DateTime dateCom, Client cliCom)
        {
            this.idCom = nombreCom;
            this.dateCom = dateCom;
            this.cliCom = cliCom;
            nombreCom++;
        }

        public int IdCom
        {
            get { return this.idCom; }
            set { this.idCom = value; }
        }

        public DateTime DateCom
        {
            get { return this.dateCom; }
            set { this.dateCom = value; }
        }

        public Client CliCom
        {
            get { return this.cliCom; }
            set { this.cliCom = value; }
        }

        /* 5 */
        public double totalCommande(){
            double total = 0;
            foreach (LigneDeCommande lign in LigneDeCommande.listLign)
            {
                if (lign.ComLign == this)
                {
                    total += lign.totalLigneCommande();
                }
            }
            return total;
        }
    }
}
