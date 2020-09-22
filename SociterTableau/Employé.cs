using System;
using System.Collections.Generic;
using System.Text;

namespace SociterTableau
{
    class Employé : Personne
    {
        private double salaire;

        public Employé(string nom, string prenom , int age, double salaire) : base(nom, prenom, age)
        { this.salaire = salaire; }

        public string toString()
        {
           return base.ToString() + salaire;

        }
        public void afficher()
        {
            base.afficher();
            Console.WriteLine("Salaire : " + salaire);

        }
    }
}
