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

        protected string type { get; set;}

        protected int quantité { get; set;}

        public article()
        {
            this.designation = "";
            this.prix = 0;
            this.quantité = 0;
            this.type = "";
        }

        public article(string designation, double prix, int quantite, string type)
        {
            this.designation = designation;
            this.prix = prix;
            this.quantité = quantite;
            this.type = type;
        }



        public void afficher()
        {
            Console.WriteLine("designation: " + designation + "prix: " +prix +"quantité: "+ quantité+ "type: "+type );
        }

        public void ajouter(int add)
        {
            quantité += add;
        }

        public void modifier(string designation, double prix, int quantite, string type)
        {
            this.designation = designation;
            this.prix = prix;
            this.quantité = quantite;
            this.type = type;
            Console.WriteLine("modification de l'article: " + designation + "prix: " + prix + "quantité: " + quantité + "type: " + type);
        }

        public void Supprimer(int delete)
        {
            if (quantité - delete > 0)
            {
                quantité = quantité - delete;
            }
            else
            {
                Console.WriteLine("impossible de supprimer plus darticle qu'il y en a, il en reste: " + quantité);    
            }
        }

        public  void acheter() { 
            
            Console.WriteLine("achat "); 
        
        }
    }

}

