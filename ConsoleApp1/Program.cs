using System;
using System.ComponentModel;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom;
            double prix;
            int quantite;
            string type;

            article article1 = new article("pomme", 12, 10, "alimentaire");
            article1.afficher();
            article1.modifier("pomme", 12, 2, "alimentaire");

            article article2 = new article("television", 500, 2, "audiovisuel");

            article artcile3 = new article("table", 200, 2, "meuble");

            Console.WriteLine("Veuillez saisir le nom et cliquer sur entrer pour continuer");
            nom = Console.ReadLine();

            Console.WriteLine("Veuillez saisir le prix et cliquer sur entrer pour continuer");
            prix = Int32.Parse(Console.ReadLine());
           
            Console.WriteLine("Veuillez saisir le prix et cliquer sur entrer pour continuer");
            quantite = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le prix et cliquer sur entrer pour continuer");
            type = Console.ReadLine();

            article articlecreer = new article(nom, prix, quantite, type);

        }
    }
}
