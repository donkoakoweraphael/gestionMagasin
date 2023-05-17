using gestionCommande.Classes;
using System;

namespace gestionCommande
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* 8 */
            // clients
            Client cli1 = new Client("DIALLO", "Issaka");
            Client.listCli.Add(cli1);
            Client cli2 = new Client("GALLO", "Irène");
            Client.listCli.Add(cli2);

            // produits
            Produit prod1 = new Produit("NES", "Nescafé", 650, 8);
            Produit.listProd.Add(prod1);
            Produit prod2 = new Produit("VIVA500", "Vivalait 500g", 750, 5);
            Produit.listProd.Add(prod2);
            Produit prod3 = new Produit("SUC", "Sucre en carreaux", 500, 15);
            Produit.listProd.Add(prod3);

            // commandes
            Commande com1 = new Commande(new DateTime(2022, 02, 01), Client.listCli.Where(cli => cli.CodeCli == 1).First());
            Commande.listCom.Add(com1);
            Commande com2 = new Commande(new DateTime(2022, 02, 02), Client.listCli.Where(cli => cli.CodeCli == 2).First());
            Commande.listCom.Add(com2);
            Commande com3 = new Commande(new DateTime(2022, 02, 03), Client.listCli.Where(cli => cli.CodeCli == 1).First());
            Commande.listCom.Add(com3);
            Commande com4 = new Commande(DateTime.Today, Client.listCli.Where(cli => cli.CodeCli == 2).First());
            Commande.listCom.Add(com4);

            // liges de commandes
            LigneDeCommande lign1 = new LigneDeCommande(3, Produit.listProd.Where(prod => prod.CodeProd == "NES").First(), Commande.listCom.Where(com => com.IdCom == 1).First());
            LigneDeCommande.listLign.Add(lign1);
            LigneDeCommande lign2 = new LigneDeCommande(1, Produit.listProd.Where(prod => prod.CodeProd == "SUC").First(), Commande.listCom.Where(com => com.IdCom == 1).First());
            LigneDeCommande.listLign.Add(lign2);
            LigneDeCommande lign3 = new LigneDeCommande(3, Produit.listProd.Where(prod => prod.CodeProd == "VIVA500").First(), Commande.listCom.Where(com => com.IdCom == 2).First());
            LigneDeCommande.listLign.Add(lign3);
            LigneDeCommande lign4 = new LigneDeCommande(3, Produit.listProd.Where(prod => prod.CodeProd == "SUC").First(), Commande.listCom.Where(com => com.IdCom == 3).First());
            LigneDeCommande.listLign.Add(lign4);

            /* 10 */
            // code pour tester les methodes
            foreach (Client cli in Client.listCli)
            {
                Console.WriteLine(cli.toString());
            }
        }
    }
}