using System;
using System.Collections.Generic;
using System.Text;

namespace SociterTableau
{
    class Personne
    {

        private String nom { get; set; }
        private String prenom { get; set; }
        private int age { get; set; }

        public Personne()
        {
            this.nom = "";
            this.prenom = "";
            this.age = 0;

        }

        public Personne(string name, string prenom, int age)
        {
            this.nom = name;
            this.prenom = prenom;
            this.age = age;

        }
        public override string ToString()
        {
            return "Person: " + nom + " " + prenom + " " + age;
        }

        public void afficher()
        {
            Console.WriteLine("[Affichage de la personne]");
            Console.WriteLine("nom: " + nom);
            Console.WriteLine("prenom: " + prenom);
            Console.WriteLine("age: " + age);
        }

        public static int operateur(int age) { return age++;}
    }
}
