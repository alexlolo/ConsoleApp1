using System;

namespace SociterTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Directeur directeur = new Directeur("lolo", "alex", 22, 100000, "service", "alexCompagny");

            chef chef1 = new chef("Dupont", "Andre", 40, 9500, "Marketing" );
            chef chef2 = new chef("Dubois", "Paige ", 24, 10000, "ResourceHumaine"); 

            Employé employé1 = new Employé("Lépicier", "Julien", 45, 2000);
            Employé employé2 = new Employé("de Launay", "Manon", 21, 1500);
            Employé employé3 = new Employé("Pelletier", "Raison", 22, 1800);
            Employé employé4 = new Employé("Perrault", "Franck", 48, 2000);
            Employé employé5 = new Employé("Devoe", "Christine ", 22, 2000);
          
            var tableauPersonne = new Personne[] { employé1, employé2, employé3, employé4, employé5, chef2, chef1, directeur };

            for (int i = 0; i < tableauPersonne.Length; i++)
            {
                tableauPersonne[i].afficher();
            }
        }
    }
}
