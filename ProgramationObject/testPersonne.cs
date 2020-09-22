using System;

namespace ProgramationObject
{
    class testPersonne
    {
        static void Main(string[] args)
        {
            Peronnes perso1 = new Peronnes("alex", "lolo", 22);
            Peronnes perso2 = new Peronnes("flo", "flo", 21);

            perso1.afficher();
            perso2.afficher();

        }
    }
}
