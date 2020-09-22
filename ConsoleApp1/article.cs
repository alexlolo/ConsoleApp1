using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;

namespace ConsoleApp1
{
    class article
    {
        protected string designation { get; set;}

        protected double prix { get; set;}

        protected int quantité { get; set;}

        public article()
        {
            this.designation = "";
            this.prix = 0;
            this.quantité = 0;
        }

        public article(string designation, double prix, int quantite)
        {
            this.designation = designation;
            this.prix = prix;
            this.quantité = quantite;
        }

        public void afficher()
        {
            Console.WriteLine($"designation:{this.designation} prix: {this.prix} quantité: {this.quantité}");
        }

        public void ajouter()
        {
            this.quantité += 1;
        }


        public void Supprimer()
        {
            if (this.quantité >= 1)
            {
                this.quantité -= 1;
            }
            else
            {
                Console.WriteLine("Plus aucune quantité n'est disponible.");
            }
        }
    }

}

