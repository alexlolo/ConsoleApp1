using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProgramationObject
{
    class Peronnes
    {
        private String nom { get; set; }
        private String prenom { get; set; }
        private int age  { get; set; }

        public Peronnes()
        {
            this.nom = "";
            this.prenom = "";
            this.age = 0;
           
        }

        public Peronnes(string name, string prenom, int age)
        {
            this.nom = name;
            this.prenom = prenom;
            this.age = age;
            
        }

        public void  afficher()
        {
            Console.WriteLine("[Affichage de la personne]");
            Console.WriteLine("nom: "+nom);
            Console.WriteLine("prenom: " + prenom);
            Console.WriteLine("age: " + age);
        }

        public static int compteur;

        public static int combien()
        {
            return compteur++;
        }
    }
}
