using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SociterTableau
{
    class Directeur : chef
    {
        private string societe;

        public Directeur(string nom, string prenom, int age, double salaire, string service, string societe) : base(nom, prenom, age, salaire, service)
        {
            this.societe = societe;
        }
        public string toString()
        {
            return base.ToString() + societe;

        }
        public void afficher()
        {
            base.afficher();
            Console.WriteLine("Service : " + societe);

        }

    }
}
