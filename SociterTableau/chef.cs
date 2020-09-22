using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SociterTableau
{
    class chef : Employé
    {
        private string service;

       public chef(string nom, string prenom, int age, double salaire, string service): base(nom, prenom, age, salaire)
        {
            this.service = service;
        }

        public string toString()
        {
           return base.ToString()+service;

        }
        public void afficher()
        {
            base.afficher();
            Console.WriteLine("Service : " + service);

        }
    }
       
}
