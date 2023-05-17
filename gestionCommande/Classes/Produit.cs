using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCommande.Classes
{
    /* 1 */
    public class Produit
    {
        private string codeProd; // Le code est unique
        // "code" dans le devoir
        private string nomProd; // nom ou designation du produit
        // "designation" dans le devoir
        private double prixUnitProd; // prix unitaire du produit (ne doit pas etre inferieur à 0)
        // "prixUnitaire" dans le devoir
        private int qteStockProd;
        // "qteStock" dans le devoir

        /* 3 */
        public static List<Produit> listProd = new List<Produit>();

        
        
        /* 2 */
        public Produit(string codeProd, string nomProd, double prixUnitProd, int qteStockProd)
        {
            this.codeProd = codeProd;
            this.nomProd = nomProd;
            this.prixUnitProd = prixUnitProd;
            this.qteStockProd = qteStockProd;
        }

        public string CodeProd
        {
            get { return this.codeProd; }
            set { this.codeProd = value; }
        }
        public string NomProd
        {
            get { return this.nomProd; }
            set { this.nomProd = value; }
        }
        public double PrixUnitProd
        {
            get { return this.prixUnitProd; }
            set { this.prixUnitProd = value; }
        }
        public int QteStockProd
        {
            get { return this.qteStockProd; }
            set { this.qteStockProd = value; }
        }
    }
}
