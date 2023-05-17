using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCommande.Classes
{
    /* 1 */
    public class LigneDeCommande
    {
        private int qteLign;
        // "qteCommandee" dans le devoir
        private DateTime dateLign;
        // absent dans le devoir
        private Produit prodLign;
        // "produit" dans le devoir
        private Commande comLign;
        // "commande" dans le devoir

        /* 3 */
        public static List<LigneDeCommande> listLign = new List<LigneDeCommande>();
        


        /* 2 */
        public LigneDeCommande(int qteLign, Produit prodLign, Commande comLign)
        {
            this.qteLign = qteLign;
            this.prodLign = prodLign;
            this.comLign = comLign;
            /* 7 */
            int index = Produit.listProd.FindIndex(unProd => unProd == prodLign);
            if (index>=0)
            {
                Produit.listProd[index].QteStockProd -= qteLign;
            }
        }

        // public LigneDeCommande(int qteLign, DateTime dateLign, Produit prodLign, Commande comLign)
        // {
        //     this.qteLign = qteLign;
        //     this.dateLign = dateLign;
        //     this.prodLign = prodLign;
        //     this.comLign = comLign;
        //     /* 7 */
        //     int index = Produit.listProd.FindIndex(unProd => unProd == prodLign);
        //     if (index>=0)
        //     {
        //         Produit.listProd[index].QteStockProd -= qteLign;
        //     }
        // }

        public int QteLign
        {
            get { return this.qteLign; }
            set { this.qteLign = value; }
        }
        public DateTime DateLign
        {
            get { return this.dateLign; }
            set { this.dateLign = value; }
        }
        public Produit ProdLign
        {
            get { return this.prodLign; }
            set { this.prodLign = value; }
        }
        public Commande ComLign
        {
            get { return this.comLign; }
            set { this.comLign = value; }
        }

        /* 4 */
        public double totalLigneCommande()
        {
            return this.qteLign * this.prodLign.PrixUnitProd;
        }
    }
}
