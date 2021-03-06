﻿using System;
using System.ComponentModel;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            article article1 = new article("pomme", 5, 10);
            article1.afficher();
        

            article article2 = new article("television", 500, 2);
            article2.afficher();

            article1.ajouter();
            article2.Supprimer();
            article1.afficher();
            article2.afficher();


            Console.WriteLine("[Creation d'un article]");

            Console.WriteLine("Nom de l'article : ");
            string nomNewArticle = Console.ReadLine();

            Console.WriteLine("Prix de l'article");
            double prixNewArticle;

            while (!double.TryParse(Console.ReadLine(), out prixNewArticle))
            {
                Console.WriteLine("Erreur : Format du prix incorrect");
            };

            Console.WriteLine("Quantité de l'article");
            int quantiteNewArticle = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Environment.NewLine);
            article newArticle = new article(nomNewArticle, prixNewArticle, quantiteNewArticle);

            newArticle.afficher();

        }
    }
}
